using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Spectrometer_CS2000.Constants
{
    class ServiceConstants
    {
        public static string ConfigMainLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public static string ServiceName = "CS2000";

        public static string StartOfJob = "SOJ";
        public static string EndOfJob = "EOJ";
        public static string ManualPassword = "1";

        public static string NameSpace { get { return "Spectrometer_CS2000"; } }

        public enum LogLevel { None, Velbose, Debug, Information, Warning, Error, Fatal };
    }
}
