
namespace Spectrometer_CS2000.View
{
    partial class FormSpectraTest
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.textBox_OnLog = new System.Windows.Forms.TextBox();
            this.groupBox_TestConnect = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_SerialPort = new System.Windows.Forms.ComboBox();
            this.button_LoadPort = new System.Windows.Forms.Button();
            this.groupBox_CheckFromSuppression = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_ResultCheckFromSuppression = new System.Windows.Forms.Label();
            this.button_CheckFromSuppression = new System.Windows.Forms.Button();
            this.label_ConnectionStatus = new System.Windows.Forms.Label();
            this.groupBox_SetNdCondition = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_SetNdCondition = new System.Windows.Forms.Button();
            this.checkBox_NdFilter = new System.Windows.Forms.CheckBox();
            this.groupBox_SetFsCondition = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_SetFsCondition = new System.Windows.Forms.Button();
            this.checkBox_FinderShutter = new System.Windows.Forms.CheckBox();
            this.groupBox_SetUserCalCondition = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_SetUserCalCondition = new System.Windows.Forms.Button();
            this.comboBox_UserCalCondition = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button_SetOptionalNdCondition = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_UseNd2 = new System.Windows.Forms.RadioButton();
            this.radioButton_UseNd1 = new System.Windows.Forms.RadioButton();
            this.radioButton_NoNd = new System.Windows.Forms.RadioButton();
            this.groupBox_SetClsUpLensCondition = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button_SetClsUpLensCondition = new System.Windows.Forms.Button();
            this.checkBox_ClsUpLens = new System.Windows.Forms.CheckBox();
            this.groupBox_Measurement = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Exposuretime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Measurement = new System.Windows.Forms.Button();
            this.checkBox_DarkMeasurement = new System.Windows.Forms.CheckBox();
            this.radioButton_DataTypeXYZ = new System.Windows.Forms.RadioButton();
            this.radioButton_DataTypexyLv = new System.Windows.Forms.RadioButton();
            this.groupBox_DarkMeasurement = new System.Windows.Forms.GroupBox();
            this.button_DarkMeasurement = new System.Windows.Forms.Button();
            this.groupBox_SetCalibrationData = new System.Windows.Forms.GroupBox();
            this.button_SetCalibrationData = new System.Windows.Forms.Button();
            this.groupBox_GetCalibrationData = new System.Windows.Forms.GroupBox();
            this.button_GetCalibrationData = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_TestConnect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_CheckFromSuppression.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_SetNdCondition.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox_SetFsCondition.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox_SetUserCalCondition.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_SetClsUpLensCondition.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox_Measurement.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox_DarkMeasurement.SuspendLayout();
            this.groupBox_SetCalibrationData.SuspendLayout();
            this.groupBox_GetCalibrationData.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Open
            // 
            this.button_Open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Open.Location = new System.Drawing.Point(3, 32);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(99, 24);
            this.button_Open.TabIndex = 0;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Close.Location = new System.Drawing.Point(108, 32);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(99, 24);
            this.button_Close.TabIndex = 1;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textBox_OnLog
            // 
            this.textBox_OnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_OnLog.Location = new System.Drawing.Point(3, 450);
            this.textBox_OnLog.Multiline = true;
            this.textBox_OnLog.Name = "textBox_OnLog";
            this.textBox_OnLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_OnLog.Size = new System.Drawing.Size(609, 94);
            this.textBox_OnLog.TabIndex = 2;
            // 
            // groupBox_TestConnect
            // 
            this.groupBox_TestConnect.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_TestConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_TestConnect.Location = new System.Drawing.Point(3, 3);
            this.groupBox_TestConnect.Name = "groupBox_TestConnect";
            this.groupBox_TestConnect.Size = new System.Drawing.Size(216, 79);
            this.groupBox_TestConnect.TabIndex = 3;
            this.groupBox_TestConnect.TabStop = false;
            this.groupBox_TestConnect.Text = "Connect";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_SerialPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Open, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_LoadPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Close, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 59);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // comboBox_SerialPort
            // 
            this.comboBox_SerialPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_SerialPort.FormattingEnabled = true;
            this.comboBox_SerialPort.Location = new System.Drawing.Point(3, 3);
            this.comboBox_SerialPort.Name = "comboBox_SerialPort";
            this.comboBox_SerialPort.Size = new System.Drawing.Size(99, 20);
            this.comboBox_SerialPort.TabIndex = 3;
            // 
            // button_LoadPort
            // 
            this.button_LoadPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_LoadPort.Location = new System.Drawing.Point(108, 3);
            this.button_LoadPort.Name = "button_LoadPort";
            this.button_LoadPort.Size = new System.Drawing.Size(99, 23);
            this.button_LoadPort.TabIndex = 2;
            this.button_LoadPort.Text = "Load Port";
            this.button_LoadPort.UseVisualStyleBackColor = true;
            this.button_LoadPort.Click += new System.EventHandler(this.button_LoadPort_Click);
            // 
            // groupBox_CheckFromSuppression
            // 
            this.groupBox_CheckFromSuppression.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_CheckFromSuppression.Location = new System.Drawing.Point(3, 88);
            this.groupBox_CheckFromSuppression.Name = "groupBox_CheckFromSuppression";
            this.groupBox_CheckFromSuppression.Size = new System.Drawing.Size(216, 75);
            this.groupBox_CheckFromSuppression.TabIndex = 4;
            this.groupBox_CheckFromSuppression.TabStop = false;
            this.groupBox_CheckFromSuppression.Text = "Check From Suppression";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label_ResultCheckFromSuppression, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_CheckFromSuppression, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 55);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label_ResultCheckFromSuppression
            // 
            this.label_ResultCheckFromSuppression.AutoSize = true;
            this.label_ResultCheckFromSuppression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ResultCheckFromSuppression.Location = new System.Drawing.Point(3, 34);
            this.label_ResultCheckFromSuppression.Name = "label_ResultCheckFromSuppression";
            this.label_ResultCheckFromSuppression.Size = new System.Drawing.Size(204, 21);
            this.label_ResultCheckFromSuppression.TabIndex = 1;
            this.label_ResultCheckFromSuppression.Text = "Result :";
            this.label_ResultCheckFromSuppression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_CheckFromSuppression
            // 
            this.button_CheckFromSuppression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CheckFromSuppression.Location = new System.Drawing.Point(3, 3);
            this.button_CheckFromSuppression.Name = "button_CheckFromSuppression";
            this.button_CheckFromSuppression.Size = new System.Drawing.Size(204, 28);
            this.button_CheckFromSuppression.TabIndex = 0;
            this.button_CheckFromSuppression.Text = "Check From Suppression";
            this.button_CheckFromSuppression.UseVisualStyleBackColor = true;
            this.button_CheckFromSuppression.Click += new System.EventHandler(this.button_CheckFromSuppression_Click);
            // 
            // label_ConnectionStatus
            // 
            this.label_ConnectionStatus.AutoSize = true;
            this.label_ConnectionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_ConnectionStatus.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_ConnectionStatus.Location = new System.Drawing.Point(3, 0);
            this.label_ConnectionStatus.Name = "label_ConnectionStatus";
            this.label_ConnectionStatus.Size = new System.Drawing.Size(609, 21);
            this.label_ConnectionStatus.TabIndex = 5;
            this.label_ConnectionStatus.Text = "Status : Disconnected";
            // 
            // groupBox_SetNdCondition
            // 
            this.groupBox_SetNdCondition.Controls.Add(this.tableLayoutPanel3);
            this.groupBox_SetNdCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SetNdCondition.Location = new System.Drawing.Point(3, 246);
            this.groupBox_SetNdCondition.Name = "groupBox_SetNdCondition";
            this.groupBox_SetNdCondition.Size = new System.Drawing.Size(221, 77);
            this.groupBox_SetNdCondition.TabIndex = 6;
            this.groupBox_SetNdCondition.TabStop = false;
            this.groupBox_SetNdCondition.Text = "Set Nd Condition";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button_SetNdCondition, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_NdFilter, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(215, 57);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // button_SetNdCondition
            // 
            this.button_SetNdCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SetNdCondition.Location = new System.Drawing.Point(3, 25);
            this.button_SetNdCondition.Name = "button_SetNdCondition";
            this.button_SetNdCondition.Size = new System.Drawing.Size(209, 29);
            this.button_SetNdCondition.TabIndex = 0;
            this.button_SetNdCondition.Text = "Set Nd Condition";
            this.button_SetNdCondition.UseVisualStyleBackColor = true;
            this.button_SetNdCondition.Click += new System.EventHandler(this.button_SetNdCondition_Click);
            // 
            // checkBox_NdFilter
            // 
            this.checkBox_NdFilter.AutoSize = true;
            this.checkBox_NdFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_NdFilter.Location = new System.Drawing.Point(3, 3);
            this.checkBox_NdFilter.Name = "checkBox_NdFilter";
            this.checkBox_NdFilter.Size = new System.Drawing.Size(209, 16);
            this.checkBox_NdFilter.TabIndex = 1;
            this.checkBox_NdFilter.Text = "ND Filter";
            this.checkBox_NdFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox_SetFsCondition
            // 
            this.groupBox_SetFsCondition.Controls.Add(this.tableLayoutPanel4);
            this.groupBox_SetFsCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SetFsCondition.Location = new System.Drawing.Point(3, 218);
            this.groupBox_SetFsCondition.Name = "groupBox_SetFsCondition";
            this.groupBox_SetFsCondition.Size = new System.Drawing.Size(216, 74);
            this.groupBox_SetFsCondition.TabIndex = 7;
            this.groupBox_SetFsCondition.TabStop = false;
            this.groupBox_SetFsCondition.Text = "Set Fs Condition";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.button_SetFsCondition, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.checkBox_FinderShutter, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(210, 54);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // button_SetFsCondition
            // 
            this.button_SetFsCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SetFsCondition.Location = new System.Drawing.Point(3, 25);
            this.button_SetFsCondition.Name = "button_SetFsCondition";
            this.button_SetFsCondition.Size = new System.Drawing.Size(204, 26);
            this.button_SetFsCondition.TabIndex = 0;
            this.button_SetFsCondition.Text = "Set Fs Condition";
            this.button_SetFsCondition.UseVisualStyleBackColor = true;
            this.button_SetFsCondition.Click += new System.EventHandler(this.button_SetFsCondition_Click);
            // 
            // checkBox_FinderShutter
            // 
            this.checkBox_FinderShutter.AutoSize = true;
            this.checkBox_FinderShutter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_FinderShutter.Location = new System.Drawing.Point(3, 3);
            this.checkBox_FinderShutter.Name = "checkBox_FinderShutter";
            this.checkBox_FinderShutter.Size = new System.Drawing.Size(204, 16);
            this.checkBox_FinderShutter.TabIndex = 1;
            this.checkBox_FinderShutter.Text = "Finder Shutter Open";
            this.checkBox_FinderShutter.UseVisualStyleBackColor = true;
            // 
            // groupBox_SetUserCalCondition
            // 
            this.groupBox_SetUserCalCondition.Controls.Add(this.tableLayoutPanel5);
            this.groupBox_SetUserCalCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SetUserCalCondition.Location = new System.Drawing.Point(3, 83);
            this.groupBox_SetUserCalCondition.Name = "groupBox_SetUserCalCondition";
            this.groupBox_SetUserCalCondition.Size = new System.Drawing.Size(221, 74);
            this.groupBox_SetUserCalCondition.TabIndex = 8;
            this.groupBox_SetUserCalCondition.TabStop = false;
            this.groupBox_SetUserCalCondition.Text = "Set User Cal Condition";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.button_SetUserCalCondition, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.comboBox_UserCalCondition, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(215, 54);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // button_SetUserCalCondition
            // 
            this.button_SetUserCalCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SetUserCalCondition.Location = new System.Drawing.Point(3, 29);
            this.button_SetUserCalCondition.Name = "button_SetUserCalCondition";
            this.button_SetUserCalCondition.Size = new System.Drawing.Size(209, 22);
            this.button_SetUserCalCondition.TabIndex = 0;
            this.button_SetUserCalCondition.Text = "Set User Cal Condition";
            this.button_SetUserCalCondition.UseVisualStyleBackColor = true;
            this.button_SetUserCalCondition.Click += new System.EventHandler(this.button_SetUserCalCondition_Click);
            // 
            // comboBox_UserCalCondition
            // 
            this.comboBox_UserCalCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_UserCalCondition.FormattingEnabled = true;
            this.comboBox_UserCalCondition.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_UserCalCondition.Location = new System.Drawing.Point(3, 3);
            this.comboBox_UserCalCondition.Name = "comboBox_UserCalCondition";
            this.comboBox_UserCalCondition.Size = new System.Drawing.Size(209, 20);
            this.comboBox_UserCalCondition.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Optional Nd";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.button_SetOptionalNdCondition, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(215, 54);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // button_SetOptionalNdCondition
            // 
            this.button_SetOptionalNdCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SetOptionalNdCondition.Location = new System.Drawing.Point(3, 21);
            this.button_SetOptionalNdCondition.Name = "button_SetOptionalNdCondition";
            this.button_SetOptionalNdCondition.Size = new System.Drawing.Size(209, 30);
            this.button_SetOptionalNdCondition.TabIndex = 0;
            this.button_SetOptionalNdCondition.Text = "Set Optional Nd Condition";
            this.button_SetOptionalNdCondition.UseVisualStyleBackColor = true;
            this.button_SetOptionalNdCondition.Click += new System.EventHandler(this.button_SetOptionalNdCondition_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_UseNd2);
            this.panel1.Controls.Add(this.radioButton_UseNd1);
            this.panel1.Controls.Add(this.radioButton_NoNd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 18);
            this.panel1.TabIndex = 1;
            // 
            // radioButton_UseNd2
            // 
            this.radioButton_UseNd2.AutoSize = true;
            this.radioButton_UseNd2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_UseNd2.Location = new System.Drawing.Point(131, 0);
            this.radioButton_UseNd2.Name = "radioButton_UseNd2";
            this.radioButton_UseNd2.Size = new System.Drawing.Size(71, 18);
            this.radioButton_UseNd2.TabIndex = 2;
            this.radioButton_UseNd2.Text = "Use Nd2";
            this.radioButton_UseNd2.UseVisualStyleBackColor = true;
            // 
            // radioButton_UseNd1
            // 
            this.radioButton_UseNd1.AutoSize = true;
            this.radioButton_UseNd1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_UseNd1.Location = new System.Drawing.Point(60, 0);
            this.radioButton_UseNd1.Name = "radioButton_UseNd1";
            this.radioButton_UseNd1.Size = new System.Drawing.Size(71, 18);
            this.radioButton_UseNd1.TabIndex = 1;
            this.radioButton_UseNd1.Text = "Use Nd1";
            this.radioButton_UseNd1.UseVisualStyleBackColor = true;
            // 
            // radioButton_NoNd
            // 
            this.radioButton_NoNd.AutoSize = true;
            this.radioButton_NoNd.Checked = true;
            this.radioButton_NoNd.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton_NoNd.Location = new System.Drawing.Point(0, 0);
            this.radioButton_NoNd.Name = "radioButton_NoNd";
            this.radioButton_NoNd.Size = new System.Drawing.Size(60, 18);
            this.radioButton_NoNd.TabIndex = 0;
            this.radioButton_NoNd.TabStop = true;
            this.radioButton_NoNd.Text = "No ND";
            this.radioButton_NoNd.UseVisualStyleBackColor = true;
            // 
            // groupBox_SetClsUpLensCondition
            // 
            this.groupBox_SetClsUpLensCondition.Controls.Add(this.tableLayoutPanel7);
            this.groupBox_SetClsUpLensCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SetClsUpLensCondition.Location = new System.Drawing.Point(3, 163);
            this.groupBox_SetClsUpLensCondition.Name = "groupBox_SetClsUpLensCondition";
            this.groupBox_SetClsUpLensCondition.Size = new System.Drawing.Size(221, 77);
            this.groupBox_SetClsUpLensCondition.TabIndex = 7;
            this.groupBox_SetClsUpLensCondition.TabStop = false;
            this.groupBox_SetClsUpLensCondition.Text = "Set Cls Up Lens";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.button_SetClsUpLensCondition, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.checkBox_ClsUpLens, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(215, 57);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // button_SetClsUpLensCondition
            // 
            this.button_SetClsUpLensCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SetClsUpLensCondition.Location = new System.Drawing.Point(3, 25);
            this.button_SetClsUpLensCondition.Name = "button_SetClsUpLensCondition";
            this.button_SetClsUpLensCondition.Size = new System.Drawing.Size(209, 29);
            this.button_SetClsUpLensCondition.TabIndex = 0;
            this.button_SetClsUpLensCondition.Text = "Set Cls Up Lens Condition";
            this.button_SetClsUpLensCondition.UseVisualStyleBackColor = true;
            this.button_SetClsUpLensCondition.Click += new System.EventHandler(this.button_SetClsUpLensCondition_Click);
            // 
            // checkBox_ClsUpLens
            // 
            this.checkBox_ClsUpLens.AutoSize = true;
            this.checkBox_ClsUpLens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_ClsUpLens.Location = new System.Drawing.Point(3, 3);
            this.checkBox_ClsUpLens.Name = "checkBox_ClsUpLens";
            this.checkBox_ClsUpLens.Size = new System.Drawing.Size(209, 16);
            this.checkBox_ClsUpLens.TabIndex = 1;
            this.checkBox_ClsUpLens.Text = "Closeup Lens";
            this.checkBox_ClsUpLens.UseVisualStyleBackColor = true;
            // 
            // groupBox_Measurement
            // 
            this.groupBox_Measurement.Controls.Add(this.tableLayoutPanel8);
            this.groupBox_Measurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Measurement.Location = new System.Drawing.Point(3, 298);
            this.groupBox_Measurement.Name = "groupBox_Measurement";
            this.groupBox_Measurement.Size = new System.Drawing.Size(216, 125);
            this.groupBox_Measurement.TabIndex = 5;
            this.groupBox_Measurement.TabStop = false;
            this.groupBox_Measurement.Text = "Measurement";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.textBox_Exposuretime, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.button_Measurement, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.checkBox_DarkMeasurement, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.radioButton_DataTypeXYZ, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.radioButton_DataTypexyLv, 1, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(210, 105);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // textBox_Exposuretime
            // 
            this.textBox_Exposuretime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Exposuretime.Location = new System.Drawing.Point(108, 3);
            this.textBox_Exposuretime.Name = "textBox_Exposuretime";
            this.textBox_Exposuretime.Size = new System.Drawing.Size(99, 21);
            this.textBox_Exposuretime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "ExposureTime";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Measurement
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.button_Measurement, 2);
            this.button_Measurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Measurement.Location = new System.Drawing.Point(3, 74);
            this.button_Measurement.Name = "button_Measurement";
            this.button_Measurement.Size = new System.Drawing.Size(204, 28);
            this.button_Measurement.TabIndex = 0;
            this.button_Measurement.Text = "Measurement";
            this.button_Measurement.UseVisualStyleBackColor = true;
            this.button_Measurement.Click += new System.EventHandler(this.button_Measurement_Click);
            // 
            // checkBox_DarkMeasurement
            // 
            this.checkBox_DarkMeasurement.AutoSize = true;
            this.tableLayoutPanel8.SetColumnSpan(this.checkBox_DarkMeasurement, 2);
            this.checkBox_DarkMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox_DarkMeasurement.Location = new System.Drawing.Point(3, 30);
            this.checkBox_DarkMeasurement.Name = "checkBox_DarkMeasurement";
            this.checkBox_DarkMeasurement.Size = new System.Drawing.Size(204, 16);
            this.checkBox_DarkMeasurement.TabIndex = 2;
            this.checkBox_DarkMeasurement.Text = "Dark Measurement";
            this.checkBox_DarkMeasurement.UseVisualStyleBackColor = true;
            // 
            // radioButton_DataTypeXYZ
            // 
            this.radioButton_DataTypeXYZ.AutoSize = true;
            this.radioButton_DataTypeXYZ.Checked = true;
            this.radioButton_DataTypeXYZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_DataTypeXYZ.Location = new System.Drawing.Point(3, 52);
            this.radioButton_DataTypeXYZ.Name = "radioButton_DataTypeXYZ";
            this.radioButton_DataTypeXYZ.Size = new System.Drawing.Size(99, 16);
            this.radioButton_DataTypeXYZ.TabIndex = 3;
            this.radioButton_DataTypeXYZ.TabStop = true;
            this.radioButton_DataTypeXYZ.Text = "X, Y, Z";
            this.radioButton_DataTypeXYZ.UseVisualStyleBackColor = true;
            // 
            // radioButton_DataTypexyLv
            // 
            this.radioButton_DataTypexyLv.AutoSize = true;
            this.radioButton_DataTypexyLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_DataTypexyLv.Location = new System.Drawing.Point(108, 52);
            this.radioButton_DataTypexyLv.Name = "radioButton_DataTypexyLv";
            this.radioButton_DataTypexyLv.Size = new System.Drawing.Size(99, 16);
            this.radioButton_DataTypexyLv.TabIndex = 4;
            this.radioButton_DataTypexyLv.TabStop = true;
            this.radioButton_DataTypexyLv.Text = "x, y, Lv";
            this.radioButton_DataTypexyLv.UseVisualStyleBackColor = true;
            // 
            // groupBox_DarkMeasurement
            // 
            this.groupBox_DarkMeasurement.Controls.Add(this.button_DarkMeasurement);
            this.groupBox_DarkMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_DarkMeasurement.Location = new System.Drawing.Point(3, 378);
            this.groupBox_DarkMeasurement.Name = "groupBox_DarkMeasurement";
            this.groupBox_DarkMeasurement.Size = new System.Drawing.Size(221, 45);
            this.groupBox_DarkMeasurement.TabIndex = 9;
            this.groupBox_DarkMeasurement.TabStop = false;
            this.groupBox_DarkMeasurement.Text = "Dark Measurement";
            // 
            // button_DarkMeasurement
            // 
            this.button_DarkMeasurement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DarkMeasurement.Location = new System.Drawing.Point(3, 17);
            this.button_DarkMeasurement.Name = "button_DarkMeasurement";
            this.button_DarkMeasurement.Size = new System.Drawing.Size(215, 25);
            this.button_DarkMeasurement.TabIndex = 0;
            this.button_DarkMeasurement.Text = "Dark Measurement";
            this.button_DarkMeasurement.UseVisualStyleBackColor = true;
            this.button_DarkMeasurement.Click += new System.EventHandler(this.button_DarkMeasurement_Click);
            // 
            // groupBox_SetCalibrationData
            // 
            this.groupBox_SetCalibrationData.Controls.Add(this.button_SetCalibrationData);
            this.groupBox_SetCalibrationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_SetCalibrationData.Location = new System.Drawing.Point(3, 169);
            this.groupBox_SetCalibrationData.Name = "groupBox_SetCalibrationData";
            this.groupBox_SetCalibrationData.Size = new System.Drawing.Size(216, 43);
            this.groupBox_SetCalibrationData.TabIndex = 10;
            this.groupBox_SetCalibrationData.TabStop = false;
            this.groupBox_SetCalibrationData.Text = "Set Calibration Data";
            // 
            // button_SetCalibrationData
            // 
            this.button_SetCalibrationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SetCalibrationData.Location = new System.Drawing.Point(3, 17);
            this.button_SetCalibrationData.Name = "button_SetCalibrationData";
            this.button_SetCalibrationData.Size = new System.Drawing.Size(210, 23);
            this.button_SetCalibrationData.TabIndex = 0;
            this.button_SetCalibrationData.Text = "Set Calibration data";
            this.button_SetCalibrationData.UseVisualStyleBackColor = true;
            this.button_SetCalibrationData.Click += new System.EventHandler(this.button_SetCalibrationData_Click);
            // 
            // groupBox_GetCalibrationData
            // 
            this.groupBox_GetCalibrationData.Controls.Add(this.button_GetCalibrationData);
            this.groupBox_GetCalibrationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_GetCalibrationData.Location = new System.Drawing.Point(3, 329);
            this.groupBox_GetCalibrationData.Name = "groupBox_GetCalibrationData";
            this.groupBox_GetCalibrationData.Size = new System.Drawing.Size(221, 43);
            this.groupBox_GetCalibrationData.TabIndex = 11;
            this.groupBox_GetCalibrationData.TabStop = false;
            this.groupBox_GetCalibrationData.Text = "Get Calibration Data";
            // 
            // button_GetCalibrationData
            // 
            this.button_GetCalibrationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_GetCalibrationData.Location = new System.Drawing.Point(3, 17);
            this.button_GetCalibrationData.Name = "button_GetCalibrationData";
            this.button_GetCalibrationData.Size = new System.Drawing.Size(215, 23);
            this.button_GetCalibrationData.TabIndex = 0;
            this.button_GetCalibrationData.Text = "Get Calibration data";
            this.button_GetCalibrationData.UseVisualStyleBackColor = true;
            this.button_GetCalibrationData.Click += new System.EventHandler(this.button_GetCalibrationData_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.AutoSize = true;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.groupBox_TestConnect, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.groupBox_CheckFromSuppression, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.groupBox_SetCalibrationData, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.groupBox_Measurement, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.groupBox_SetFsCondition, 0, 3);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 5;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(222, 426);
            this.tableLayoutPanel9.TabIndex = 12;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.AutoSize = true;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel10.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.groupBox_SetUserCalCondition, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.groupBox_DarkMeasurement, 0, 5);
            this.tableLayoutPanel10.Controls.Add(this.groupBox_SetClsUpLensCondition, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.groupBox_GetCalibrationData, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.groupBox_SetNdCondition, 0, 3);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(388, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 6;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(227, 426);
            this.tableLayoutPanel10.TabIndex = 13;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.label_ConnectionStatus, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.textBox_OnLog, 0, 2);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(615, 547);
            this.tableLayoutPanel11.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel9);
            this.panel2.Controls.Add(this.tableLayoutPanel10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 426);
            this.panel2.TabIndex = 6;
            // 
            // FormSpectraTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 547);
            this.Controls.Add(this.tableLayoutPanel11);
            this.Name = "FormSpectraTest";
            this.Text = "FormTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSpectraTest_FormClosing);
            this.Load += new System.EventHandler(this.FormSpectraTest_Load);
            this.groupBox_TestConnect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_CheckFromSuppression.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox_SetNdCondition.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox_SetFsCondition.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox_SetUserCalCondition.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_SetClsUpLensCondition.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox_Measurement.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox_DarkMeasurement.ResumeLayout(false);
            this.groupBox_SetCalibrationData.ResumeLayout(false);
            this.groupBox_GetCalibrationData.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.TextBox textBox_OnLog;
        private System.Windows.Forms.GroupBox groupBox_TestConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox_SerialPort;
        private System.Windows.Forms.Button button_LoadPort;
        private System.Windows.Forms.GroupBox groupBox_CheckFromSuppression;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_ResultCheckFromSuppression;
        private System.Windows.Forms.Button button_CheckFromSuppression;
        private System.Windows.Forms.Label label_ConnectionStatus;
        private System.Windows.Forms.GroupBox groupBox_SetNdCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_SetNdCondition;
        private System.Windows.Forms.CheckBox checkBox_NdFilter;
        private System.Windows.Forms.GroupBox groupBox_SetFsCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_SetFsCondition;
        private System.Windows.Forms.CheckBox checkBox_FinderShutter;
        private System.Windows.Forms.GroupBox groupBox_SetUserCalCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button_SetUserCalCondition;
        private System.Windows.Forms.ComboBox comboBox_UserCalCondition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_SetOptionalNdCondition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_UseNd2;
        private System.Windows.Forms.RadioButton radioButton_UseNd1;
        private System.Windows.Forms.RadioButton radioButton_NoNd;
        private System.Windows.Forms.GroupBox groupBox_SetClsUpLensCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button_SetClsUpLensCondition;
        private System.Windows.Forms.CheckBox checkBox_ClsUpLens;
        private System.Windows.Forms.GroupBox groupBox_Measurement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox textBox_Exposuretime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Measurement;
        private System.Windows.Forms.CheckBox checkBox_DarkMeasurement;
        private System.Windows.Forms.RadioButton radioButton_DataTypeXYZ;
        private System.Windows.Forms.RadioButton radioButton_DataTypexyLv;
        private System.Windows.Forms.GroupBox groupBox_DarkMeasurement;
        private System.Windows.Forms.Button button_DarkMeasurement;
        private System.Windows.Forms.GroupBox groupBox_SetCalibrationData;
        private System.Windows.Forms.Button button_SetCalibrationData;
        private System.Windows.Forms.GroupBox groupBox_GetCalibrationData;
        private System.Windows.Forms.Button button_GetCalibrationData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Panel panel2;
    }
}

