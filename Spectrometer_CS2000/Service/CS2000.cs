using CS2000Cal;
using Spectrometer_CS2000.Entity;
using Spectrometer_CS2000.Repository;
using System;
using System.Collections.Generic;

namespace Spectrometer_CS2000.Service
{
    public delegate void JobDoneHandler(JobDoneEventArgs eventArgs);
    public delegate void ErrorHandler(string errorMessage);

    class CS2000
    {
		private static CS2000 _instance = null;

        CS2000CalClass _cs2000 = new CS2000CalClass();

        public event ErrorHandler OnError;

        public event EventHandler OnConnect;
        public event EventHandler OnClose;

        private string _com = string.Empty;

        public bool IsConnected { get; private set; }

        public static CS2000 Instance
        {
            get
            {
                lock (typeof(CS2000))
                {
                    if (_instance == null)
                    {
                        _instance = new CS2000();
                    }

                    return _instance;
                }
            }
        }

        public CS2000()
        {

        }

        public short Connect(List<Parameter> parameters)
        {
            return Connect(parameters[0]?.Value.ToString());
        }

        /// <summary>
        /// Connect
        /// </summary>
        /// <param name="com"></param>
        /// <returns></returns>
        public short Connect(string com)
        {
            Int16 result;
            result = _cs2000.ConnectInstrument(1, com);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    this._com = com;
                    break;
                case 20:
                    errorMessage = "Open() The profreading date and time do not accord.";
                    break;
                case -1:
                    errorMessage = string.Format($"Open() Parameter does not correct. {nameof(com)}={com}");
                    break;
                case -2:
                    errorMessage = "Open() Connection is not complete.";
                    break;
                case -3:
                    errorMessage = "Open() Port open do not failed.";
                    break;
                case -100:
                    errorMessage = "Open() The serial number of connected CS-2000A does not correct.";
                    break;
                case -101:      // Key file 은 C:\CS2000 폴더 내부에 존재해야함.
                    errorMessage = "Open() There is no KEY-file.";
                    break;
                default:
                    errorMessage = string.Format("Open() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }
            else
            {
                ConnectDone();
            }

            return result;
        }

        protected virtual void ConnectDone()
        {
            IsConnected = true;

            if (OnConnect != null)
            {
                OnConnect(this, new EventArgs());
            }
        }

        protected virtual void Disconnected()
        {
            IsConnected = false;

            if (OnClose != null)
            {
                OnClose(this, new EventArgs());
            }
        }

        public short Disconnect(List<Parameter> parameters)
        {
            return Disconnect();
        }

        public short Disconnect()
        {
            Int16 result;
            result = _cs2000.ConnectInstrument(0, this._com);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    this._com = string.Empty;
                    break;
                case 20:
                    errorMessage = "Close() The profreading date and time do not accord.";
                    break;
                case -1:
                    errorMessage = string.Format($"Close() Parameter does not correct. {nameof(this._com)}={this._com}");
                    break;
                case -2:
                    errorMessage = "Close() Connection is not complete.";
                    break;
                case -3:
                    errorMessage = "Close() Port open do not failed.";
                    break;
                case -100:
                    errorMessage = "Close() The serial number of connected CS-2000A does not correct.";
                    break;
                case -101:
                    errorMessage = "Close() There is no KEY-file.";
                    break;
                default:
                    errorMessage = string.Format("Close() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }
            else
            {
                Disconnected();
            }

            return result;
        }

        public short SetNdCondition(List<Parameter> parameters)
        {
            return SetNdCondition((short)parameters[0]?.Value);
        }

        /// <summary>
        /// Nd filter 설정
        /// </summary>
        /// <param name="ndMode">0 : Out 1: In</param>
        /// <returns></returns>
        public short SetNdCondition(short ndMode)
        {
            short result = _cs2000.SetNDCondition(ndMode);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -1:
                    errorMessage = string.Format($"SetNdCondition() Parameter error. {nameof(ndMode)}={ndMode}");
                    break;
                case -2:
                    errorMessage = "SetNdCondition() Connection is not complete.";
                    break;

                default:
                    errorMessage = string.Format("SetNdCondition() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }

        public short SetFsCondition(List<Parameter> parameters)
        {
            return SetFsCondition((short)parameters[0]?.Value);
        }

        /// <summary>
        /// Finder-shutter 설정
        /// </summary>
        /// <param name="fsMode">0 : Open
        /// 1 : Close</param>
        /// <returns></returns>
        public short SetFsCondition(short fsMode)
        {
            short result = _cs2000.SetFSCondition(fsMode);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -1:
                    errorMessage = string.Format($"SetFsCondition() Parameter error. {nameof(fsMode)}={fsMode}");
                    break;
                case -2:
                    errorMessage = "SetFsCondition() Connection is not complete.";
                    break;

                default:
                    errorMessage = string.Format("SetFsCondition() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }

        public short SetUserCalCondition(List<Parameter> parameters)
        {
            return SetUserCalCondition((short)parameters[0]?.Value);
        }

        /// <summary>
        /// Set the user calibration channel
        /// </summary>
        /// <param name="calibrationChannel">0 : Do not the user calibration
        /// 1 ~ 10 : Do user calibration</param>
        /// <returns></returns>
        public short SetUserCalCondition(short calibrationChannel)
        {
            short result = _cs2000.SetNDCondition(calibrationChannel);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -2:
                    errorMessage = string.Format($"SetFsCondition() Connection is not complete.");
                    break;
                case -5:
                    errorMessage = string.Format($"SetFsCondition() The calbration data do not exist. {nameof(calibrationChannel)}={calibrationChannel}");
                    break;

                default:
                    errorMessage = string.Format("SetFsCondition() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }

        public short SetOptionalNdCondition(List<Parameter> parameters)
        {
            return SetOptionalNdCondition((short)parameters[0]?.Value);
        }

        /// <summary>
        /// Set the optional ND Number.
        /// </summary>
        /// <param name="ndOption">0 : Do not optional ND
        /// 1 : Use the ND1
        /// 2 : Use the ND2</param>
        /// <returns></returns>
        public short SetOptionalNdCondition(short ndOption)
        {
            short result = _cs2000.SetOptionalNDCondition(ndOption);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -2:
                    errorMessage = "SetOptionalNdCondition() Connection is not complete.";
                    break;
                case -5:
                    errorMessage = string.Format($"SetOptionalNdCondition() The calbration data do not exist. {nameof(ndOption)}={ndOption}");
                    break;
                case -30:
                    errorMessage = "SetOptionalNdCondition() Flash memory error.";
                    break;

                default:
                    errorMessage = string.Format("Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }

        public short SetClsUpLensCondition(List<Parameter> parameters)
        {
            return SetClsUpLensCondition((short)parameters[0]?.Value);
        }

        /// <summary>
        /// Select the closeup lens
        /// <param name="clsUpLesnMode">0 : Do not the closeup lens
        /// 1 : Set the closeup lens</param>
        /// </summary>
        /// <returns></returns>
        public short SetClsUpLensCondition(short clsUpLesnMode)
        {
            short result = _cs2000.SetClsUpLensCondition(clsUpLesnMode);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -2:
                    errorMessage = "SetClsUpLensCondition() Connection is not complete.";
                    break;
                case -5:
                    errorMessage = string.Format($"SetClsUpLensCondition() The calbration data do not exist. {nameof(clsUpLesnMode)}={clsUpLesnMode}");
                    break;
                case -30:
                    errorMessage = "SetClsUpLensCondition() Flash memory error.";
                    break;

                default:
                    errorMessage = string.Format("Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="job"></param>
        /// <returns>!= 0 : error</returns>
        public short RunJob(JobCS2000 job, string processId = "")
        {
            DUT dut = new DUT();

            switch (job.MethodName.ToLower())
            {
                case "connect":
                    dut.Result = Connect(job.Parameters);
                    break;
                case "disconnect":
                    dut.Result = Disconnect(job.Parameters);
                    break;
                case "set nd condition":
                    dut.Result = SetNdCondition(job.Parameters);
                    break;
                case "set fs condition":
                    dut.Result = SetFsCondition(job.Parameters);
                    break;
                case "set user cal condition":
                    dut.Result = SetUserCalCondition(job.Parameters);
                    break;
                case "set optional ndcondition":
                    dut.Result = SetOptionalNdCondition(job.Parameters);
                    break;
                case "set cls up lens condition":
                    dut.Result = SetClsUpLensCondition(job.Parameters);
                    break;
                case "do measurement":
                    float[] spectralData = new float[401];
                    float[] colorData = new float[3];
                    float dataLevel = 0;

                    dut.Result = DoMeasurement(job.Parameters, ref spectralData, ref colorData, ref dataLevel);

                    dut.AddInspectionResult(job.Id, spectralData, colorData, dataLevel);

                    // 결과값을 어떻게 할 지 결 정 하 자
                    //throw new NotImplementedException();
                    break;
                case "dark measurement":
                    dut.Result = DarkMeasurement(job.Parameters);
                    break;
                case "get calibration data":
                    dut.Result = GetCalibrationData(job.Parameters);
                    break;
                case "set calibration data":
                    dut.Result = SetCalibrationData(job.Parameters);
                    break;
                case "do communication":
                    string receiveMessage = string.Empty;
                    dut.Result = DoCommunitcation(job.Parameters, ref receiveMessage);

                    // 결과 receiveMessage 어떻게할지 결 정 하 자
                    //throw new NotImplementedException();
                    break;
                case "check from suppression":
                    dut.Result = CheckFromSuppression(job.Parameters);
                    break;

                default:
                    return -1;
            }

            //throw new NotImplementedException();

            dut.AddResult(job.Id, dut.Result);

            if (!string.IsNullOrEmpty(processId))
            {
                dut.ProcessId = processId;
            }

            DUTRepository.Instance.Add(dut);

            return dut.Result;
        }

        public short DoMeasurement(List<Parameter> parameters, ref float[] spectralData, ref float[] colorData, ref float dataLevel)
        {
            int exposureTime;

            short darkType;

            short measurementType;

            int.TryParse(parameters[0].Value.ToString(), out exposureTime);
            short.TryParse(parameters[1].Value.ToString(), out darkType);
            short.TryParse(parameters[2].Value.ToString(), out measurementType);

            return DoMeasurement(exposureTime, darkType, measurementType, ref spectralData, ref colorData, ref dataLevel);
        }

        /// <summary>
        /// Start the measurement
        /// </summary>
        /// <param name="exposureTime">노출시간</param>
        /// <param name="darkType">0 : Use the dark data of DarkMeasurement function
        /// 1 : Use the dark data of every measurement using a exposure time.</param>
        /// <param name="measurementType">DataType
        /// 0 : X,Y,Z
        /// 1 : x,y,Lv</param>
        /// <param name="spectralData">Spectral radiance value data</param>
        /// <param name="colorData">Color value data setting in the "measurementType"</param>
        /// <param name="dataLevel">Percentage of max count value.</param>
        /// <returns></returns>
        public short DoMeasurement(int exposureTime, short darkType, short measurementType, ref float[] spectralData, ref float[] colorData, ref float dataLevel)
        {
            short result = _cs2000.DoMeasurement(exposureTime, darkType, measurementType, ref spectralData, ref colorData, ref dataLevel);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -1:
                    errorMessage = string.Format($"DoMeasurement() Parameter error. {nameof(exposureTime)}={exposureTime}, {nameof(darkType)}={darkType}, {nameof(measurementType)}={measurementType}");
                    break;
                case -2:
                    errorMessage = "DoMeasurement() Connection is not complete.";
                    break;
                case -10:
                    errorMessage = "DoMeasurement() Measurement calculation failed.";
                    break;
                case -20:
                    errorMessage = "DoMeasurement() Calbration data does not exist.";
                    break;
                case -21:
                    errorMessage = "DoMeasurement() Dark data does not exist.";
                    break;
                case -90:
                    errorMessage = "DoMeasurement() Too dark. Do not measuremnt.";
                    break;
                case -91:
                    errorMessage = "DoMeasurement() Too bright. Do not measurement.";
                    break;

                default:
                    errorMessage = string.Format("Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }

        public short DarkMeasurement(List<Parameter> parameters)
        {
            return DarkMeasurement();
        }

        /// <summary>
        /// Start the dark measurement
        /// </summary>
        /// <returns></returns>
        public short DarkMeasurement()
        {
            short result = _cs2000.DarkMeasurement();

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -2:
                    errorMessage = "DarkMeasurement() Connection is not complete.";
                    break;

                default:
                    errorMessage = string.Format("DarkMeasurement() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }

        public short GetCalibrationData(List<Parameter> parameters)
        {
            return GetCalibrationData();
        }

        /// <summary>
        /// Save the calibration data to PC
        /// </summary>
        /// <returns></returns>
        public short GetCalibrationData()
        {
            short result = _cs2000.GetCalibrationData();

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -1:
                    errorMessage = "GetCalibrationData() Connection is not complete.";
                    break;
                case -4:
                    errorMessage = "GetCalibrationData() Serial number does not exist.";
                    break;

                default:
                    errorMessage = string.Format("GetCalibrationData() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }

        public short SetCalibrationData(List<Parameter> parameters)
        {
            return SetCalibrationData();
        }

        /// <summary>
        /// Get to the calibration data saved to PC.
        /// </summary>
        /// <returns></returns>
        public short SetCalibrationData()
        {
            short result = _cs2000.SetCalibrationData();

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -20:
                    errorMessage = "SetCalibrationData() Calibration data does not exist.";
                    break;

                default:
                    errorMessage = string.Format("SetCalibrationData() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }

        public short DoCommunitcation(List<Parameter> parameters, ref string receiveMessage)
        {
            return DoCommunitcation(parameters[0]?.Value.ToString(), ref receiveMessage);
        }

        /// <summary>
        /// Message communicate
        /// </summary>
        /// <param name="sendMessage">보낼 메세지</param>
        /// <param name="receiveMessage">받은 메세지</param>
        /// <returns></returns>
        public short DoCommunitcation(string sendMessage, ref string receiveMessage)
        {
            short result = _cs2000.DoCommunication(sendMessage, ref receiveMessage);

            string errorMessage = string.Empty;

            switch (result)
            {
                case 0:
                    break;
                case -2:
                    errorMessage = "DoCommunication() Connection is not complete.";
                    break;

                default:
                    errorMessage = string.Format("DoCommunication() Error code error. {0}", result);
                    break;
            }

            if (result != 0)
            {
                ErrorOccured(errorMessage);
            }

            return result;
        }
        public short CheckFromSuppression(List<Parameter> parameters)
        {
            return (short)(CheckFromSuppression() ? 0 : -1);
        }


        public bool CheckFromSuppression()
        {
            return _cs2000.CheckFROMSuppression();
        }


        protected virtual void ErrorOccured(string message)
        {
            if (OnError != null)
            {
                OnError(message);
            }
        }
    }
}
