using Spectrometer_CS2000.Constants;
using Spectrometer_CS2000.Entity;
using Spectrometer_CS2000.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Spectrometer_CS2000.Repository
{
    class DUTRepository
    {
        private static DUTRepository _instance = null;
        public static DUTRepository Instance
        {
            get
            {
                lock (typeof(DUTRepository))
                {
                    if (_instance == null)
                    {
                        _instance = new DUTRepository();
                    }
                    return _instance;
                }
            }
        }

        private DUTRepository()
        {
            //string Dir = Path.Combine(ServiceConstants.ConfigMainLocation, "DEVICE_CONFIG");

            //if (!Directory.Exists(Dir))
            //{
            //    Directory.CreateDirectory(Dir);
            //}

            //iniConfig = new Ini(Path.Combine(Dir, "DUT.ini"));

            //load();
        }

        public event EventHandler OnUpdateDUTs;

        public List<DUT> DUTs = new List<DUT>();

        public List<DUT> GetDUTs()
        {
            return DUTs;
        }

        public DUT GetById(string id)
        {
            return (DUT)GetDUTs().FirstOrDefault(dut => dut.ProcessId.Equals(id));
        }

        public void RemoveById(string id)
        {
            DUTs = GetDUTs().Where(dut => !dut.ProcessId.Equals(id)).ToList();

            OnUpdateDUTsEvent();
        }

        public bool IsEmpty()
        {
            return GetDUTs().Count.Equals(0) ? true : false;
        }

        public bool Add(DUT dut)
        {
            DUTs.Add(dut);

            OnUpdateDUTsEvent();

            return true;
        }

        public bool Save(string dutName)
        {
            if (IsEmpty()) return false;

            string dir = Path.Combine(ServiceConstants.ConfigMainLocation, dutName, "DUT Result.ini");

            Ini iniResult = new Ini(dir);

            foreach (var item in GetDUTs().Select((value, index) => (value, index)))
            {
                DUT dut = (DUT)item.value;
                int index = item.index;
                
                string sectionName = string.Format("Model/{0}", index);
                iniResult.IniWriteValue(sectionName, "Id", dut.ProcessId);
                iniResult.IniWriteValue(sectionName, "Result", dut.Result.ToString());
            }

            return true;
        }

        private bool load(string dutPath)
        {
            string dir = Path.Combine(dutPath);

            Ini iniResult = new Ini(dir);

            string[] sectionNames = iniResult.GetSectionNames();

            foreach (string sectionName in sectionNames)
            {
                if (sectionName.StartsWith("Model/"))
                {
                    DUT dut = new DUT();
                    dut.ProcessId = iniResult.IniReadValue(sectionName, "Id");
                    short result;
                    short.TryParse(iniResult.IniReadValue(sectionName, "Result"), out result);
                    dut.Result = result;    

                    Add(dut);
                }
            }

            return true;
        }

        private void OnUpdateDUTsEvent()
        {
            OnUpdateDUTs?.Invoke(this, EventArgs.Empty);
        }
    }
}
