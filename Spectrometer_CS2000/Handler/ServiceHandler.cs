using Spectrometer_CS2000.Entity;
using Spectrometer_CS2000.Provider;
using Spectrometer_CS2000.Repository;
using Spectrometer_CS2000.Service;
using System.Linq;
using System;

namespace Spectrometer_CS2000.Handler
{
    class ServiceHandler
    {
        public event JobDoneHandler OnJobDone;
        public event ErrorHandler OnError; 
        public string JobListAsJSON(string sData)
        {
            JobRepository jobRepository = JobRepository.Instance;

            JobCS2000 job = jobRepository.GetJobs().First();

            return job.GetAsString();
        }

        /// <summary>
        /// 동기 작업
        /// </summary>
        /// <param name="jobAsJSON"></param>
        /// <returns></returns>
        public short Run(string jobAsJSON)
        {
            Job tempJob = Job.SetFromString(jobAsJSON);

            JobCS2000 job = JobRepository.Instance.GetById(tempJob.Id);

            CS2000 rs232 = ((CS2000)ServiceProvider.Instance.GetService("CS2000"));

            short result = rs232.RunJob(job);

            OnOnJobDoneEvent(job.Id, job.Name, result);

            return result;
        }

        public bool SetConfig(string comPort)
        {
            Config config = new Config();

            config.COMPort = comPort;

            try
            {
                ConfigRepository.Instance.SetConfig(config);

                return true;
            }
            catch (System.Exception ex)
            {
                ErrorOccured(ex.Message);

                return false;
            }
        }

        public bool SaveConfig()
        {
            return ConfigRepository.Instance.Save();
        }

        protected virtual void ErrorOccured(string errorMessage)
        {
            OnError?.Invoke(string.Format("[{0}] : {1}", Constants.ServiceConstants.ServiceName, errorMessage));
        }

        protected virtual void OnOnJobDoneEvent(string id, string name, short result)
        {
            OnJobDone?.Invoke(new JobDoneEventArgs(id, name, result));
        }

        protected virtual void OnOnJobDoneEvent(JobDoneEventArgs jobDoneEventArgs)
        {
            OnJobDone?.Invoke(jobDoneEventArgs);
        }
    }
}
