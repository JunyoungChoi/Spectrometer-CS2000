using Spectrometer_CS2000.Constants;
using Spectrometer_CS2000.Util;
using Spectrometer_CS2000.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Spectrometer_CS2000.Repository
{
    class ConfigRepository
    {
        private static ConfigRepository _instance = null;
        public static ConfigRepository Instance
        {
            get
            {
                lock (typeof(ConfigRepository))
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigRepository();
                    }
                    return _instance;
                }
            }
        }

        private Ini iniConfig;

        private ConfigRepository()
        {
            string dir = Path.Combine(ServiceConstants.ConfigMainLocation, "Config");

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            iniConfig = new Ini(Path.Combine(dir, "Config.ini"));

            load();
        }

        public Config Config = new Config();

        public event EventHandler OnUpdateConfig;

        public void SetConfig(Config config)
        {
            this.Config = config;

            OnUpdateConfigEvent();
        }

        public Config GetConfig()
        {
            return Config;
        }


        private void OnUpdateConfigEvent()
        {
            OnUpdateConfig?.Invoke(this, EventArgs.Empty);
        }

        public bool Save()
        {
            string sectionName = "CS2000";

            iniConfig.IniWriteValue(sectionName, "COM Port", Config.COMPort);

            return true;
        }

        private bool load()
        {
            string sectionName = "CS2000";

            Config config = new Config();

            config.COMPort = iniConfig.IniReadValue(sectionName, "COM Port");

            SetConfig(config);

            return true;
        }
    }
}
