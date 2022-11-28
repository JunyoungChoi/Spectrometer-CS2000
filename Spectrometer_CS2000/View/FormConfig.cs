using Spectrometer_CS2000.Repository;
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
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        public void TEST()
        {

        }

        private void button_ReloadCOMPort_Click(object sender, EventArgs e)
        {
            comboBox_COMPort.Items.Clear();
            comboBox_COMPort.SelectedItem = null;

            string[] ports = System.IO.Ports.SerialPort.GetPortNames();

            comboBox_COMPort.Items.AddRange(ports);
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            button_ReloadCOMPort_Click(null, null);

            if (comboBox_COMPort.Items.Contains(ConfigRepository.Instance.Config.COMPort))
            {
                comboBox_COMPort.SelectedItem = ConfigRepository.Instance.Config.COMPort;
            }
            else
            {
                ConfigRepository.Instance.Config.COMPort = string.Empty;
                ConfigRepository.Instance.Save();
            }
        }

        private void button_SaveConfig_Click(object sender, EventArgs e)
        {
            ConfigRepository.Instance.Config.COMPort = comboBox_COMPort.SelectedItem?.ToString();

            ConfigRepository.Instance.Save();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
