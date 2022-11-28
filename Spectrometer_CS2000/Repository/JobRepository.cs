using Spectrometer_CS2000.Entity;
using Spectrometer_CS2000.Constants;
using Spectrometer_CS2000.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Spectrometer_CS2000.Repository
{
    class JobRepository
    {
        private static JobRepository _instance = null;
        public static JobRepository Instance
        {
            get
            {
                lock (typeof(JobRepository))
                {
                    if (_instance == null)
                    {
                        _instance = new JobRepository();
                    }
                    return _instance;
                }
            }
        }

        private Ini iniConfig;

        private JobRepository()
        {
            string Dir = Path.Combine(ServiceConstants.ConfigMainLocation, "CS2000");

            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }

            iniConfig = new Ini(Path.Combine(Dir, "Job.ini"));

            load();
        }

        public event EventHandler OnUpdateJobs;

        public List<JobCS2000> jobs = new List<JobCS2000>();

        public List<JobCS2000> GetJobs()
        {
            return jobs;
        }

        public void ModifyJob(JobCS2000 job)
        {
            for (int i = 0; i < jobs.Count; i++)
            {
                if (jobs[i].Id.Equals(job.Id))
                {
                    jobs[i].Name = job.Name;
                    jobs[i].Parameters = job.Parameters;
                }
            }
        }

        public JobCS2000 GetById(string id)
        {
            return GetJobs().FirstOrDefault(job => job.Id.Equals(id));
        }

        public void RemoveById(string id)
        {
            jobs = GetJobs().Where(job => !job.Id.Equals(id)).ToList();

            OnUpdateJobsEvent();
        }

        public bool IsEmpty()
        {
            return jobs.Count == 0;
        }

        public bool Add(JobCS2000 job)
        {
            jobs.Add(job);

            OnUpdateJobsEvent();

            return true;
        }

        public bool Save()
        {
            if (IsEmpty()) return false;

            foreach (var item in GetJobs().Select((value, index) => (value, index)))
            {
                JobCS2000 job = item.value;
                int index = item.index;

                string sectionName = string.Format("Job/{0}", index);
                iniConfig.IniWriteValue(sectionName, "Id", job.Id);
                iniConfig.IniWriteValue(sectionName, "Name", job.Name);
                iniConfig.IniWriteValue(sectionName, "Method", job.MethodName);

                try
                {
                    iniConfig.IniWriteValue(sectionName, "Parameter1", job.Parameters[0]?.Value.ToString());
                    iniConfig.IniWriteValue(sectionName, "Parameter2", job.Parameters[1]?.Value.ToString());
                    iniConfig.IniWriteValue(sectionName, "Parameter3", job.Parameters[2]?.Value.ToString());
                }
                catch
                {

                }
            }

            return true;
        }

        private bool load()
        {
            string[] sectionNames = iniConfig.GetSectionNames();

            foreach (string sectionName in sectionNames)
            {
                if (sectionName.StartsWith("Job/"))
                {
                    string id = iniConfig.IniReadValue(sectionName, "Id");
                    string name = iniConfig.IniReadValue(sectionName, "Name");
                    string method = iniConfig.IniReadValue(sectionName, "Method");

                    List<Parameter> parameters = new List<Parameter>();
                    List<ParameterDescription> parameterDescription = ParameterDescriptionRepository.Instance.GetParameters(method);

                    for (int i = 0; i < parameterDescription.Count; i++)
                    {
                        string parameterIndex = string.Format("Parameter{0}", i + 1);

                        Parameter parameterI = new Parameter(parameterDescription[i].Name, iniConfig.IniReadValue(sectionName, parameterIndex));

                        parameters.Add(parameterI);
                    }

                    JobCS2000 job = new JobCS2000(id);
                    job.Name = name;
                    job.MethodName = method;
                    job.Parameters = parameters;

                    Add(job);
                }
            }

            return true;
        }

        private void OnUpdateJobsEvent()
        {
            OnUpdateJobs?.Invoke(this, EventArgs.Empty);
        }
    }
}
