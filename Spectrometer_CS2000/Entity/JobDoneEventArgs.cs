using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectrometer_CS2000.Entity
{
    public class JobDoneEventArgs : EventArgs
    {
        public string Id { get; private set; }
        public short Result { get; private set; }
        public string Name { get; private set; }

        public JobDoneEventArgs(string id, string name, short result)
        {
            this.Id = id;
            this.Name = name;
            this.Result = result;
        }
    }
}
