
namespace Spectrometer_CS2000.View
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_COMPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ReloadCOMPort = new System.Windows.Forms.Button();
            this.groupBox_ConnectionSetting = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_SaveConfig = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.groupBox_ConnectionSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_COMPort
            // 
            this.comboBox_COMPort.FormattingEnabled = true;
            this.comboBox_COMPort.Location = new System.Drawing.Point(100, 31);
            this.comboBox_COMPort.Name = "comboBox_COMPort";
            this.comboBox_COMPort.Size = new System.Drawing.Size(121, 20);
            this.comboBox_COMPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // button_ReloadCOMPort
            // 
            this.button_ReloadCOMPort.Location = new System.Drawing.Point(255, 31);
            this.button_ReloadCOMPort.Name = "button_ReloadCOMPort";
            this.button_ReloadCOMPort.Size = new System.Drawing.Size(75, 23);
            this.button_ReloadCOMPort.TabIndex = 2;
            this.button_ReloadCOMPort.Text = "Reload";
            this.button_ReloadCOMPort.UseVisualStyleBackColor = true;
            this.button_ReloadCOMPort.Click += new System.EventHandler(this.button_ReloadCOMPort_Click);
            // 
            // groupBox_ConnectionSetting
            // 
            this.groupBox_ConnectionSetting.Controls.Add(this.label1);
            this.groupBox_ConnectionSetting.Controls.Add(this.comboBox_COMPort);
            this.groupBox_ConnectionSetting.Controls.Add(this.button_ReloadCOMPort);
            this.groupBox_ConnectionSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ConnectionSetting.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ConnectionSetting.Name = "groupBox_ConnectionSetting";
            this.groupBox_ConnectionSetting.Size = new System.Drawing.Size(406, 209);
            this.groupBox_ConnectionSetting.TabIndex = 4;
            this.groupBox_ConnectionSetting.TabStop = false;
            this.groupBox_ConnectionSetting.Text = "Connection";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_SaveConfig);
            this.panel1.Controls.Add(this.button_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 41);
            this.panel1.TabIndex = 5;
            // 
            // button_SaveConfig
            // 
            this.button_SaveConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_SaveConfig.Location = new System.Drawing.Point(256, 0);
            this.button_SaveConfig.Name = "button_SaveConfig";
            this.button_SaveConfig.Size = new System.Drawing.Size(75, 41);
            this.button_SaveConfig.TabIndex = 2;
            this.button_SaveConfig.Text = "Save";
            this.button_SaveConfig.UseVisualStyleBackColor = true;
            this.button_SaveConfig.Click += new System.EventHandler(this.button_SaveConfig_Click);
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Close.Location = new System.Drawing.Point(331, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 41);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(406, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_ConnectionSetting);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.groupBox_ConnectionSetting.ResumeLayout(false);
            this.groupBox_ConnectionSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_COMPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ReloadCOMPort;
        private System.Windows.Forms.GroupBox groupBox_ConnectionSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_SaveConfig;
        private System.Windows.Forms.Button button_Close;
    }
}