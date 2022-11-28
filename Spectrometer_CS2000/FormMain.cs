using Spectrometer_CS2000.Provider;
using Spectrometer_CS2000.Repository;
using Spectrometer_CS2000.Service;
using Spectrometer_CS2000.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Spectrometer_CS2000
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).Connect(ConfigRepository.Instance.Config.COMPort);
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).Disconnect();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormConfig)ServiceProvider.Instance.GetForm("FormConfig")).ShowDialog();
        }

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormJob)ServiceProvider.Instance.GetForm("FormJob")).ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text += string.Format(" v{0}", this.ProductVersion);

            Spectometer_CS2000.Handler.LogHandler.WriteLog(string.Format("Program Started. Version={0}", this.ProductVersion));


            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnClose += CS2000_OnClose;
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnConnect += CS2000_OnConnect;
            ((CS2000)ServiceProvider.Instance.GetService("CS2000")).OnError += CS2000_OnError;
        }

        private void CS2000_OnError(string errorMessage)
        {
            if (this.Visible == true)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        System.Windows.Forms.MessageBox.Show(errorMessage);
                    });
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(errorMessage);
                }
            }
        }

        private void CS2000_OnConnect(object sender, EventArgs e)
        {
            if(this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    button_Status.BackColor = Color.LimeGreen;
                    button_Status.FlatAppearance.BorderColor = Color.LimeGreen;
                    button_Status.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
                    button_Status.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
                    button_Status.FlatAppearance.CheckedBackColor = Color.LimeGreen;
                    button_Status.Text = "Status : Connected";
                });
            }
            else
            {
                button_Status.BackColor = Color.LimeGreen;
                button_Status.FlatAppearance.BorderColor = Color.LimeGreen;
                button_Status.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
                button_Status.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
                button_Status.FlatAppearance.CheckedBackColor = Color.LimeGreen;
                button_Status.Text = "Status : Connected";
            }
        }

        private void CS2000_OnClose(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    button_Status.BackColor = SystemColors.Control;
                    button_Status.FlatAppearance.BorderColor = SystemColors.Control;
                    button_Status.FlatAppearance.MouseOverBackColor = SystemColors.Control;
                    button_Status.FlatAppearance.MouseDownBackColor = SystemColors.Control;
                    button_Status.FlatAppearance.CheckedBackColor = SystemColors.Control;
                    button_Status.Text = "Status : Disconnected";
                });
            }
            else
            {
                button_Status.BackColor = SystemColors.Control;
                button_Status.FlatAppearance.BorderColor = SystemColors.Control;
                button_Status.FlatAppearance.MouseOverBackColor = SystemColors.Control;
                button_Status.FlatAppearance.MouseDownBackColor = SystemColors.Control;
                button_Status.FlatAppearance.CheckedBackColor = SystemColors.Control;
                button_Status.Text = "Status : Disconnected";
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (((CS2000)ServiceProvider.Instance.GetService("CS2000")).IsConnected)
            {
                CS2000_OnConnect(this, EventArgs.Empty);
            }
            else
            {
                CS2000_OnClose(this, EventArgs.Empty);
            }
        }

        private void testToolStripMenuItem_Test_Click(object sender, EventArgs e)
        {
            ((FormSpectraTest)ServiceProvider.Instance.GetForm("FormTest")).ShowDialog();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Spectometer_CS2000.Handler.LogHandler.WriteLog(string.Format("Program Ended. Version={0}", this.ProductVersion));

        }
    }
}
