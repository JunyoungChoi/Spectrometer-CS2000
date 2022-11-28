using System;
using System.IO;
using Spectrometer_CS2000.Constants;

namespace Spectometer_CS2000.Handler
{
    static class LogHandler
    {
        private static string logDir;
        private static string logFile;
        private static string logPath;
        private static int todayDay;
        static LogHandler()
        {
            //logDir = System.IO.Path.Combine(ServiceConstants.ConfigMainLocation, "Log");
            //logFile = string.Format("log_{0}.log", DateTime.Now.ToString("yyyyMMdd"));
            //logPath = Path.Combine(logDir, logFile);
            //todayDay = DateTime.Now.Day;

            //createDirectory(logDir);
            //createLog(logPath);
        }

        public static void WriteLog(string message, ServiceConstants.LogLevel logLevel = ServiceConstants.LogLevel.Debug)
        {
            if (todayDay != DateTime.Now.Day)
            {
                todayDay = DateTime.Now.Day;

                logFile = string.Format("log_{0}.log", DateTime.Now.ToString("yyyyMMdd"));
                logPath = Path.Combine(logDir, logFile);
            }

            string logMessage = string.Empty;

            switch (logLevel)
            {
                case ServiceConstants.LogLevel.None:
                    logMessage = string.Format("{0} [{1}] : {2}{3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), ServiceConstants.ServiceName, message, System.Environment.NewLine);
                    System.Diagnostics.Debug.WriteLine(logMessage);
                    break;

                case ServiceConstants.LogLevel.Debug:
                    logMessage = string.Format("{0} [{1}] [DBG] : {2}{3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), ServiceConstants.ServiceName, message, System.Environment.NewLine);
                    break;

                case ServiceConstants.LogLevel.Error:
                    logMessage = string.Format("{0} [{1}] [ERR] : {2}{3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), ServiceConstants.ServiceName, message, System.Environment.NewLine);

                    break;

                case ServiceConstants.LogLevel.Fatal:
                    logMessage = string.Format("{0} [{1}] [FAT] : {2}{3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), ServiceConstants.ServiceName, message, System.Environment.NewLine);

                    break;

                case ServiceConstants.LogLevel.Information:
                    logMessage = string.Format("{0} [{1}] [INF] : {2}{3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), ServiceConstants.ServiceName, message, System.Environment.NewLine);

                    break;

                case ServiceConstants.LogLevel.Velbose:
                    logMessage = string.Format("{0} [{1}] [VEL] : {2}{3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), ServiceConstants.ServiceName, message, System.Environment.NewLine);

                    break;

                case ServiceConstants.LogLevel.Warning:
                    logMessage = string.Format("{0} [{1}] [WAR] : {2}{3}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), ServiceConstants.ServiceName, message, System.Environment.NewLine);

                    break;
            }

            writeLog(logMessage);
        }

        private static void createDirectory(string logDir)
        {
            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }
        }

        private static void createLog(string logPath)
        {
            if (!File.Exists(logPath))
            {
                File.Create(logPath);
            }
        }
        private static void writeLog(string logMessage)
        {
            //using (FileStream fs = new FileStream(logPath, FileMode.Append))
            //using (StreamWriter sw = new StreamWriter(fs))
            //{
            //    sw.Write(logMessage);
            //}
        }
    }
}
