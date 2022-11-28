using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Spectrometer_CS2000.Entity
{
    class DUT
    {
        public event EventHandler<short> OnUpdateResult;
        public event EventHandler<object[]> OnInspectResult;
        public DUT()
        {
            JobResults = new Dictionary<string, short>();
            InspectionResult = new Dictionary<string, object[]>();
        }

        //public string SerialNumber { get; set; }
        public string ProcessId { get; set; }
        public short Result { get; set; }

        public Dictionary<string, short> JobResults { get; set; }
        public bool AddResult(string jobID, short result)
        {
            JobResults.Add(jobID, result);

            OnUpdateResultEvent(result);

            return true;
        }

        public Dictionary<string, object[]> InspectionResult { get; set; }
        public bool AddInspectionResult(string jobID, params object[] result)
        {
            InspectionResult.Add(jobID, result);

            OnUpdateInspectResultEvent(result);

            return true;
        }

        public string GetResultAsString()
        {
            return JsonSerializer.Serialize<Dictionary<string, short>>(JobResults);
        }

        public bool SetJobsFromString(string jobsAsJSON)
        {
            JobResults = JsonSerializer.Deserialize<Dictionary<string, short>>(jobsAsJSON);

            return true;
        }

        private void OnUpdateResultEvent(short result)
        {
            if (OnUpdateResult != null)
            {
                OnUpdateResult(this, result);
            }
        }

        private void OnUpdateInspectResultEvent(object[] result)
        {
            if (OnInspectResult != null)
            {
                OnInspectResult(this, result);
            }
        }


    }
}
