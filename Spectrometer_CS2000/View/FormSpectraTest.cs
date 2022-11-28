using Spectrometer_CS2000.Provider;
using Spectrometer_CS2000.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spectrometer_CS2000.View
{
    public partial class FormSpectraTest : Form
    {
        public FormSpectraTest()
        {
            InitializeComponent();

        }

        private void SpectraMagic_OnError(string errorMessage)
        {
            if (textBox_OnLog.InvokeRequired)
            {
                textBox_OnLog.Invoke((MethodInvoker)delegate
                {
                    textBox_OnLog.AppendText(string.Format("{0}{1}", errorMessage, System.Environment.NewLine));
                });
            }
            else
            {
                textBox_OnLog.AppendText(string.Format("{0}{1}", errorMessage, System.Environment.NewLine));
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (comboBox_SerialPort.SelectedItem == null)
            {
                MessageBox.Show("COM 포트를 확인하세요.");

                return;
            }

            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).Connect(comboBox_SerialPort.SelectedItem.ToString()).ToString());
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).Disconnect();
        }

        private void button_LoadPort_Click(object sender, EventArgs e)
        {
            comboBox_SerialPort.Items.Clear();
            comboBox_SerialPort.SelectedItem = null;

            string[] ports = System.IO.Ports.SerialPort.GetPortNames();

            comboBox_SerialPort.Items.AddRange(ports);
        }

        private void FormSpectraTest_Load(object sender, EventArgs e)
        {
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnError += SpectraMagic_OnError;
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnConnect += SpectraMagic_OnConnect;
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnClose += SpectraMagic_OnClose;

            if (((CS2000)ServiceProvider.Instance.GetService("CS2000")).IsConnected)
            {
                SpectraMagic_OnConnect(this, EventArgs.Empty);
            }
            else
            {
                SpectraMagic_OnClose(this, EventArgs.Empty);
            }
        }

        private void SpectraMagic_OnConnect(object sender, EventArgs e)
        {
            if (label_ConnectionStatus.InvokeRequired)
            {
                label_ConnectionStatus.Invoke((MethodInvoker)delegate
                {
                    label_ConnectionStatus.Text = "Status : Connected";
                });
            }
            else
            {
                label_ConnectionStatus.Text = "Status : Connected";
            }
        }

        private void SpectraMagic_OnClose(object sender, EventArgs e)
        {
            if (label_ConnectionStatus.InvokeRequired)
            {
                label_ConnectionStatus.Invoke((MethodInvoker)delegate
                {
                    label_ConnectionStatus.Text = "Status : Disconnected";
                });
            }
            else
            {
                label_ConnectionStatus.Text = "Status : Disconnected";
            }
        }

        private void button_CheckFromSuppression_Click(object sender, EventArgs e)
        {
            string result = string.Format("Result : {0}", ((CS2000)ServiceProvider.Instance.GetService("CS2000")).CheckFromSuppression().ToString());

            if (label_ResultCheckFromSuppression.InvokeRequired)
            {
                label_ResultCheckFromSuppression.Invoke((MethodInvoker)delegate
                {
                    label_ResultCheckFromSuppression.Text = result;
                });
            }
            else
            {
                label_ResultCheckFromSuppression.Text = result;
            }
        }

        private void button_SetNdCondition_Click(object sender, EventArgs e)
        {
            short ndMode;

            if (checkBox_NdFilter.Checked)
            {
                ndMode = 1;
            }
            else
            {
                ndMode = 0;
            }

            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).SetNdCondition(ndMode).ToString());
        }

        private void button_SetFsCondition_Click(object sender, EventArgs e)
        {
            short fsMode;

            if (checkBox_FinderShutter.Checked)
            {
                fsMode = 0;
            }
            else
            {
                fsMode = 1;
            }

            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).SetFsCondition(fsMode).ToString());
        }

        private void button_SetUserCalCondition_Click(object sender, EventArgs e)
        {
            if (comboBox_UserCalCondition.SelectedItem == null)
            {
                MessageBox.Show("User Cal Condition is not selected.");

                return;
            }

            short userCalCondition;

            short.TryParse(comboBox_UserCalCondition.SelectedItem.ToString(), out userCalCondition);

            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).SetUserCalCondition(userCalCondition).ToString());
        }

        private void button_SetOptionalNdCondition_Click(object sender, EventArgs e)
        {
            short ndOption = 0;

            if (radioButton_NoNd.Checked)
            {
                ndOption = 0;
            }
            else if (radioButton_UseNd1.Checked)
            {
                ndOption = 1;
            }
            else if (radioButton_UseNd2.Checked)
            {
                ndOption = 2;
            }

            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).SetOptionalNdCondition(ndOption).ToString());
        }

        private void button_SetClsUpLensCondition_Click(object sender, EventArgs e)
        {
            short clsMode;

            if (checkBox_ClsUpLens.Checked)
            {
                clsMode = 1;
            }
            else
            {
                clsMode = 0;
            }

            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).SetClsUpLensCondition(clsMode).ToString());
        }

        private void button_Measurement_Click(object sender, EventArgs e)
        {
            int exposureTime;

            if (!int.TryParse(textBox_Exposuretime.Text, out exposureTime))
            {
                MessageBox.Show("Exposuretime error.");

                return;
            }
            else
            {
                if (exposureTime < 5000 || exposureTime > 12000000)
                {
                    MessageBox.Show("Exposuretime must be greater than 5000 and less than 12000000");

                    return;
                }
            }

            short darkMeasurement;

            if (checkBox_DarkMeasurement.Checked)
            {
                darkMeasurement = 0;
            }
            else
            {
                darkMeasurement = 1;
            }

            short measurementType = 0;

            if (radioButton_DataTypeXYZ.Checked)
            {
                measurementType = 0;
            }
            else
            {
                measurementType = 1;
            }

            float[] spectralData = new float[401];
            float[] colorData = new float[3];
            float dataLevel = 0;

            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).DoMeasurement(exposureTime, darkMeasurement, measurementType, ref spectralData, ref colorData, ref dataLevel).ToString());
        }

        private void button_DarkMeasurement_Click(object sender, EventArgs e)
        {
            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).DarkMeasurement().ToString());
        }

        private void button_SetCalibrationData_Click(object sender, EventArgs e)
        {
            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).SetCalibrationData().ToString());
        }

        private void button_GetCalibrationData_Click(object sender, EventArgs e)
        {
            addLog(((CS2000)ServiceProvider.Instance.GetService("CS2000")).GetCalibrationData().ToString());
        }

        private void FormSpectraTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnError -= SpectraMagic_OnError;
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnConnect -= SpectraMagic_OnConnect;
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnClose -= SpectraMagic_OnClose;
        }

        private void addLog(string message)
        {
            if (textBox_OnLog.InvokeRequired)
            {
                textBox_OnLog.Invoke((MethodInvoker)delegate
                {
                    textBox_OnLog.AppendText(string.Format("{0}{1}", message, Environment.NewLine));
                });
            }
            else
            {
                textBox_OnLog.AppendText(string.Format("{0}{1}", message, Environment.NewLine));
            }
        }
    }
}
