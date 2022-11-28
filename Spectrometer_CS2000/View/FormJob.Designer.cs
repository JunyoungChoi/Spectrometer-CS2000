
namespace Spectrometer_CS2000.View
{
    partial class FormJob
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
            this.button_Save = new System.Windows.Forms.Button();
            this.button_ModifyJob = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_AddJob = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_NewJob = new System.Windows.Forms.Button();
            this.button_RemoveJob = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_JobName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView_JobList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Parameter3 = new System.Windows.Forms.TextBox();
            this.textBox_Parameter2 = new System.Windows.Forms.TextBox();
            this.textBox_Parameter1 = new System.Windows.Forms.TextBox();
            this.label_Parameter1 = new System.Windows.Forms.Label();
            this.label_Parameter2 = new System.Windows.Forms.Label();
            this.label_Parameter3 = new System.Windows.Forms.Label();
            this.comboBox_Method = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_RunJob = new System.Windows.Forms.Button();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_JobList)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Save.Location = new System.Drawing.Point(447, 3);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(185, 41);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_ModifyJob
            // 
            this.button_ModifyJob.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ModifyJob.Enabled = false;
            this.button_ModifyJob.Location = new System.Drawing.Point(148, 3);
            this.button_ModifyJob.Name = "button_ModifyJob";
            this.button_ModifyJob.Size = new System.Drawing.Size(71, 41);
            this.button_ModifyJob.TabIndex = 8;
            this.button_ModifyJob.Text = "MODIFY";
            this.button_ModifyJob.UseVisualStyleBackColor = true;
            this.button_ModifyJob.Click += new System.EventHandler(this.button_ModifyJob_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.button_ModifyJob, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_AddJob, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(222, 47);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // button_AddJob
            // 
            this.button_AddJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_AddJob.Location = new System.Drawing.Point(3, 3);
            this.button_AddJob.Name = "button_AddJob";
            this.button_AddJob.Size = new System.Drawing.Size(68, 41);
            this.button_AddJob.TabIndex = 3;
            this.button_AddJob.Text = "ADD";
            this.button_AddJob.UseVisualStyleBackColor = true;
            this.button_AddJob.Click += new System.EventHandler(this.button_AddJob_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_Save, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(350, 400);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(635, 47);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // button_NewJob
            // 
            this.button_NewJob.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_NewJob.Location = new System.Drawing.Point(271, 3);
            this.button_NewJob.Name = "button_NewJob";
            this.button_NewJob.Size = new System.Drawing.Size(67, 41);
            this.button_NewJob.TabIndex = 4;
            this.button_NewJob.Text = "NEW";
            this.button_NewJob.UseVisualStyleBackColor = true;
            this.button_NewJob.Click += new System.EventHandler(this.button_NewJob_Click);
            // 
            // button_RemoveJob
            // 
            this.button_RemoveJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_RemoveJob.Enabled = false;
            this.button_RemoveJob.Location = new System.Drawing.Point(3, 3);
            this.button_RemoveJob.Name = "button_RemoveJob";
            this.button_RemoveJob.Size = new System.Drawing.Size(67, 41);
            this.button_RemoveJob.TabIndex = 3;
            this.button_RemoveJob.Text = "REMOVE";
            this.button_RemoveJob.UseVisualStyleBackColor = true;
            this.button_RemoveJob.Click += new System.EventHandler(this.button_RemoveJob_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_NewJob, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_RemoveJob, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 400);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 47);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Method";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_JobName
            // 
            this.textBox_JobName.Location = new System.Drawing.Point(363, 14);
            this.textBox_JobName.Name = "textBox_JobName";
            this.textBox_JobName.Size = new System.Drawing.Size(248, 21);
            this.textBox_JobName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name :";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(36, 14);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(248, 21);
            this.textBox_Id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_JobName);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox_Id);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(629, 47);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "작업속성";
            // 
            // dataGridView_JobList
            // 
            this.dataGridView_JobList.AllowUserToAddRows = false;
            this.dataGridView_JobList.AllowUserToDeleteRows = false;
            this.dataGridView_JobList.AllowUserToResizeRows = false;
            this.dataGridView_JobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_JobList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_JobList.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_JobList.MultiSelect = false;
            this.dataGridView_JobList.Name = "dataGridView_JobList";
            this.dataGridView_JobList.ReadOnly = true;
            this.dataGridView_JobList.RowHeadersVisible = false;
            this.dataGridView_JobList.RowTemplate.Height = 23;
            this.dataGridView_JobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_JobList.Size = new System.Drawing.Size(341, 391);
            this.dataGridView_JobList.TabIndex = 2;
            this.dataGridView_JobList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_JobList_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(350, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.53846F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.46154F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(635, 391);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.textBox_Parameter3, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.textBox_Parameter2, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.textBox_Parameter1, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label_Parameter1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label_Parameter2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label_Parameter3, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.comboBox_Method, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 56);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(627, 140);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // textBox_Parameter3
            // 
            this.textBox_Parameter3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Parameter3.Location = new System.Drawing.Point(82, 83);
            this.textBox_Parameter3.Name = "textBox_Parameter3";
            this.textBox_Parameter3.Size = new System.Drawing.Size(542, 21);
            this.textBox_Parameter3.TabIndex = 12;
            // 
            // textBox_Parameter2
            // 
            this.textBox_Parameter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Parameter2.Location = new System.Drawing.Point(82, 56);
            this.textBox_Parameter2.Name = "textBox_Parameter2";
            this.textBox_Parameter2.Size = new System.Drawing.Size(542, 21);
            this.textBox_Parameter2.TabIndex = 11;
            // 
            // textBox_Parameter1
            // 
            this.textBox_Parameter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Parameter1.Location = new System.Drawing.Point(82, 29);
            this.textBox_Parameter1.Name = "textBox_Parameter1";
            this.textBox_Parameter1.Size = new System.Drawing.Size(542, 21);
            this.textBox_Parameter1.TabIndex = 10;
            // 
            // label_Parameter1
            // 
            this.label_Parameter1.AutoSize = true;
            this.label_Parameter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Parameter1.Location = new System.Drawing.Point(3, 26);
            this.label_Parameter1.Name = "label_Parameter1";
            this.label_Parameter1.Size = new System.Drawing.Size(73, 27);
            this.label_Parameter1.TabIndex = 7;
            this.label_Parameter1.Text = "Parameter 1";
            this.label_Parameter1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Parameter2
            // 
            this.label_Parameter2.AutoSize = true;
            this.label_Parameter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Parameter2.Location = new System.Drawing.Point(3, 53);
            this.label_Parameter2.Name = "label_Parameter2";
            this.label_Parameter2.Size = new System.Drawing.Size(73, 27);
            this.label_Parameter2.TabIndex = 8;
            this.label_Parameter2.Text = "Parameter 2";
            this.label_Parameter2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Parameter3
            // 
            this.label_Parameter3.AutoSize = true;
            this.label_Parameter3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Parameter3.Location = new System.Drawing.Point(3, 80);
            this.label_Parameter3.Name = "label_Parameter3";
            this.label_Parameter3.Size = new System.Drawing.Size(73, 27);
            this.label_Parameter3.TabIndex = 9;
            this.label_Parameter3.Text = "Parameter 3";
            this.label_Parameter3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_Method
            // 
            this.comboBox_Method.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Method.FormattingEnabled = true;
            this.comboBox_Method.Location = new System.Drawing.Point(82, 3);
            this.comboBox_Method.Name = "comboBox_Method";
            this.comboBox_Method.Size = new System.Drawing.Size(542, 20);
            this.comboBox_Method.TabIndex = 13;
            this.comboBox_Method.SelectedIndexChanged += new System.EventHandler(this.comboBox_Method_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 201);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 190);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.12035F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.87965F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Controls.Add(this.button_RunJob, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_JobList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox_Result, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1157, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button_RunJob
            // 
            this.button_RunJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_RunJob.Location = new System.Drawing.Point(991, 400);
            this.button_RunJob.Name = "button_RunJob";
            this.button_RunJob.Size = new System.Drawing.Size(163, 47);
            this.button_RunJob.TabIndex = 11;
            this.button_RunJob.Text = "RUN";
            this.button_RunJob.UseVisualStyleBackColor = true;
            this.button_RunJob.Click += new System.EventHandler(this.button_RunJob_Click);
            // 
            // listBox_Result
            // 
            this.listBox_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Result.FormattingEnabled = true;
            this.listBox_Result.ItemHeight = 12;
            this.listBox_Result.Location = new System.Drawing.Point(991, 3);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(163, 391);
            this.listBox_Result.TabIndex = 12;
            // 
            // FormJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormJob";
            this.Text = "FormJob";
            this.Load += new System.EventHandler(this.FormJob_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_JobList)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_ModifyJob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button_AddJob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_NewJob;
        private System.Windows.Forms.Button button_RemoveJob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_JobName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView_JobList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_RunJob;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.TextBox textBox_Parameter3;
        private System.Windows.Forms.TextBox textBox_Parameter2;
        private System.Windows.Forms.TextBox textBox_Parameter1;
        private System.Windows.Forms.Label label_Parameter1;
        private System.Windows.Forms.Label label_Parameter2;
        private System.Windows.Forms.Label label_Parameter3;
        private System.Windows.Forms.ComboBox comboBox_Method;
    }
}