using Spectrometer_CS2000.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectrometer_CS2000.Entity
{
    class JobCS2000 : Job
    {
        public string MethodName = string.Empty;

        public List<Parameter> Parameters = new List<Parameter>();

        public JobCS2000(string id) : base(id)
        {

        }

        public JobCS2000() : base()
        {

        }

    }
}
