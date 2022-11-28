using Spectrometer_CS2000.Repository;
using Spectrometer_CS2000.Entity;
using ISSOFT;
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
    public partial class FormJob : Form
    {
        DataTable dt = new DataTable();

        public FormJob()
        {
            InitializeComponent();

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("NAME", typeof(string));
            dt.Columns.Add("METHOD", typeof(string));
            dt.Columns.Add("PARAMETER1", typeof(string));
            dt.Columns.Add("PARAMETER1_TYPE", typeof(Type));
            dt.Columns.Add("PARAMETER2", typeof(string));
            dt.Columns.Add("PARAMETER2_TYPE", typeof(Type));
            dt.Columns.Add("PARAMETER3", typeof(string));
            dt.Columns.Add("PARAMETER3_TYPE", typeof(Type));
        }

        private void FormJob_Load(object sender, EventArgs e)
        {
            comboBox_Method.Items.Clear();
            comboBox_Method.Items.AddRange(ParameterDescriptionRepository.Instance.GetMethods().ToArray());

            ExtensionMethods.DoubleBuffered(dataGridView_JobList, true);

            dataGridView_JobList.DataSource = dt;

            JobRepository.Instance.OnUpdateJobs += UpdateJobs;

            UpdateJobs(null, null);
        }

        private void UpdateJobs(object sender, EventArgs e)
        {
            if (dataGridView_JobList.InvokeRequired)
            {
                dataGridView_JobList.Invoke((MethodInvoker)delegate
                {
                    dataGridView_JobList.SuspendLayout();

                    dt.Clear();

                    foreach (JobCS2000 job in JobRepository.Instance.GetJobs())
                    {
                        DataRow dr = dt.NewRow();

                        dr["ID"] = job.Id;
                        dr["NAME"] = job.Name;
                        dr["METHOD"] = job.MethodName;

                        if (job.Parameters.Count > 0)
                        {
                            dr["PARAMETER1"] = job.Parameters[0].Value;
                            dr["PARAMETER1_TYPE"] = job.Parameters[0].Type;
                        }

                        if (job.Parameters.Count > 1)
                        {
                            dr["PARAMETER2"] = job.Parameters[1].Value;
                            dr["PARAMETER2_TYPE"] = job.Parameters[1].Type;
                        }

                        if (job.Parameters.Count > 2)
                        {
                            dr["PARAMETER3"] = job.Parameters[2].Value;
                            dr["PARAMETER3_TYPE"] = job.Parameters[2].Type;
                        }
                        
                        dt.Rows.Add(dr);
                    }

                    dataGridView_JobList.ResumeLayout();
                });
            }
            else
            {
                dataGridView_JobList.SuspendLayout();

                dt.Clear();

                foreach (JobCS2000 job in JobRepository.Instance.GetJobs())
                {
                    DataRow dr = dt.NewRow();

                    dr["ID"] = job.Id;
                    dr["NAME"] = job.Name;
                    dr["METHOD"] = job.MethodName;

                    if (job.Parameters.Count > 0)
                    {
                        dr["PARAMETER1"] = job.Parameters[0].Value;
                        dr["PARAMETER1_TYPE"] = job.Parameters[0].Type;
                    }

                    if (job.Parameters.Count > 1)
                    {
                        dr["PARAMETER2"] = job.Parameters[1].Value;
                        dr["PARAMETER2_TYPE"] = job.Parameters[1].Type;
                    }

                    if (job.Parameters.Count > 2)
                    {
                        dr["PARAMETER3"] = job.Parameters[2].Value;
                        dr["PARAMETER3_TYPE"] = job.Parameters[2].Type;
                    }

                    dt.Rows.Add(dr);
                }

                dataGridView_JobList.ResumeLayout();
            }
        }

        private void showParameter(string methodName)
        {
            this.SuspendLayout();

            List<ParameterDescription> parameters = ParameterDescriptionRepository.Instance.GetParameters(methodName);

            switch (parameters.Count)
            {
                case 0:
                    label_Parameter1.Visible = false;
                    textBox_Parameter1.Visible = false;

                    label_Parameter2.Visible = false;
                    textBox_Parameter2.Visible = false;

                    label_Parameter3.Visible = false;
                    textBox_Parameter3.Visible = false;
                    break;

                case 1:
                    label_Parameter1.Visible = true;
                    textBox_Parameter1.Visible = true;

                    label_Parameter1.Text = parameters[0].Name;
                    textBox_Parameter1.Text = string.Empty;

                    label_Parameter2.Visible = false;
                    textBox_Parameter2.Visible = false;

                    label_Parameter3.Visible = false;
                    textBox_Parameter3.Visible = false;
                    break;

                case 2:
                    label_Parameter1.Visible = true;
                    textBox_Parameter1.Visible = true;

                    label_Parameter1.Text = parameters[0].Name;
                    textBox_Parameter1.Text = string.Empty;

                    label_Parameter2.Visible = true;
                    textBox_Parameter2.Visible = true;

                    label_Parameter1.Text = parameters[1].Name;
                    textBox_Parameter1.Text = string.Empty;

                    label_Parameter3.Visible = false;
                    textBox_Parameter3.Visible = false;
                    break;

                case 3:
                    label_Parameter1.Visible = true;
                    textBox_Parameter1.Visible = true;

                    label_Parameter1.Text = parameters[0].Name;
                    textBox_Parameter1.Text = string.Empty;

                    label_Parameter2.Visible = true;
                    textBox_Parameter2.Visible = true;

                    label_Parameter2.Text = parameters[1].Name;
                    textBox_Parameter2.Text = string.Empty; 
                    
                    label_Parameter3.Visible = true;
                    textBox_Parameter3.Visible = true;

                    label_Parameter3.Text = parameters[2].Name;
                    textBox_Parameter3.Text = string.Empty;
                    break;
            }

            this.ResumeLayout();
        }

        private void comboBox_Method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Method.SelectedItem != null)
            {
                showParameter(comboBox_Method.SelectedItem.ToString());
            }   
        }

        private void dataGridView_JobList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            string id = dt.Rows[e.RowIndex]["ID"].ToString();

            JobCS2000 job = JobRepository.Instance.GetById(id);

            textBox_Id.Text = job.Id;
            textBox_JobName.Text = job.Name;

            comboBox_Method.SelectedItem = job.MethodName;

            showParameter(job.MethodName);

            if (textBox_Parameter1.Visible)
            {
                label_Parameter1.Text = job.Parameters[0].Name;
                textBox_Parameter1.Text = job.Parameters[0].Value.ToString();
            }

            if (textBox_Parameter2.Visible)
            {
                label_Parameter2.Text = job.Parameters[1].Name;
                textBox_Parameter2.Text = job.Parameters[1].Value.ToString();
            }

            if (textBox_Parameter3.Visible)
            {
                label_Parameter3.Text = job.Parameters[2].Name;
                textBox_Parameter3.Text = job.Parameters[2].Value.ToString();
            }
        }

        private JobCS2000 makeJobFromInput()
        {
            JobCS2000 job = new JobCS2000();

            job.MethodName = comboBox_Method.SelectedItem.ToString();
            job.Name = textBox_JobName.Text;

            var parameters = ParameterDescriptionRepository.Instance.GetParameters(job.MethodName);

            if (parameters.Count > 0)
            {
                Parameter parameter = new Parameter(parameters[0].Name, textBox_Parameter1.Text);
                parameter.Type = parameters[0].Type;

                job.Parameters.Add(parameter);
            }

            if (parameters.Count > 1)
            {
                Parameter parameter = new Parameter(parameters[1].Name, textBox_Parameter2.Text);
                parameter.Type = parameters[1].Type;

                job.Parameters.Add(parameter);
            }

            if (parameters.Count > 2)
            {
                Parameter parameter = new Parameter(parameters[2].Name, textBox_Parameter3.Text);
                parameter.Type = parameters[2].Type;

                job.Parameters.Add(parameter);
            }

            return job;
        }

        private void button_AddJob_Click(object sender, EventArgs e)
        {
            //if (!isModyfyMode())
            //{
                JobCS2000 job = makeJobFromInput();

                JobRepository.Instance.Add(job);

                textBox_Id.Text = job.Id;
            //}
        }

        private bool isModyfyMode()
        {
            return textBox_Id.Text.Equals("") ? false : true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            JobRepository.Instance.Save();
        }

        private void button_RunJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Id.Text))
            {
                MessageBox.Show("Select job.");

                return;
            }

            string result = ((Service.CS2000)Provider.ServiceProvider.Instance.GetService("CS2000")).RunJob(JobRepository.Instance.GetById(textBox_Id.Text)).ToString();

            listBox_Result.Items.Add(string.Format("{0} Run.", textBox_Id.Text));
            listBox_Result.Items.Add(string.Format("Result : {0}", result));
        }

        private void button_RemoveJob_Click(object sender, EventArgs e)
        {
            if (isModyfyMode())
            {
                JobRepository.Instance.RemoveById(textBox_Id.Text);
            }
        }

        private void button_NewJob_Click(object sender, EventArgs e)
        {
            initInput();
        }

        private void initInput()
        {
            comboBox_Method.SelectedItem = null;
            textBox_Id.Text = string.Empty;
            textBox_JobName.Text = string.Empty;
            textBox_Parameter1.Text = string.Empty;
            textBox_Parameter2.Text = string.Empty;
            textBox_Parameter3.Text = string.Empty;

            textBox_Parameter1.Visible = true;
            label_Parameter1.Visible = true;
            label_Parameter1.Text = "Parameter 1";

            textBox_Parameter2.Visible = true;
            label_Parameter2.Visible = true;
            label_Parameter2.Text = "Parameter 2";

            textBox_Parameter3.Visible = true;
            label_Parameter3.Visible = true;
            label_Parameter3.Text = "Parameter 3";
        }

        private void button_ModifyJob_Click(object sender, EventArgs e)
        {
            if (isModyfyMode())
            {
                JobRepository.Instance.ModifyJob(makeJobFromInput());

                UpdateJobs(null, null);
            }
        }
    }
}
