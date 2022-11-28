using Spectrometer_CS2000.Entity;
using ISSOFT.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Spectrometer_CS2000.Repository
{
    class ParameterDescriptionRepository
    {
        private static ParameterDescriptionRepository _instance = null;
        public static ParameterDescriptionRepository Instance
        {
            get
            {
                lock (typeof(ParameterDescriptionRepository))
                {
                    if (_instance == null)
                    {
                        _instance = new ParameterDescriptionRepository();
                    }
                    return _instance;
                }
            }
        }

        FuncParameter _funcParameter = null;

        public List<string> GetMethods()
        {
            return _funcParameter.ParameterDescription.Keys.ToList();
        }


        private ParameterDescriptionRepository()
        {
            _funcParameter = new FuncParameter();

            LoadFunction();
        }

        public List<ParameterDescription> GetParameters(string methodName)
        {
            List<ParameterDescription> parameters = null;

            _funcParameter.ParameterDescription.TryGetValue(methodName, out parameters);

            return parameters;
        }

        public void LoadFunction()
        {
            string[,] excelData;
            try
            {
                string filePath = Path.Combine(Constants.ServiceConstants.ConfigMainLocation, "Function List", "FunctionList.xlsx");

                if (!File.Exists(filePath))
                {
                    throw new Exception(string.Format("파일이 존재하지 않습니다. {0}", filePath));
                }

                excelData = UtilExcel.ReadAll(filePath, "FuncParam");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);

                return;
            }

            Dictionary<string, List<ParameterDescription>> parameterTypes = new Dictionary<string, List<ParameterDescription>>();

            for (int row = 1; row < excelData.GetLength(0); row++)
            {
                string methodName = excelData[row, 0];

                if (string.IsNullOrEmpty(methodName))
                {
                    continue;
                }

                parameterTypes[methodName] = new List<ParameterDescription>();

                for (int col = 1; col < excelData.GetLength(1); col += 2)
                {
                    if (string.IsNullOrEmpty(excelData[row, col]))
                    {
                        break;
                    }

                    ParameterDescription parameterDescription = new ParameterDescription();

                    switch (excelData[row, col].ToLower())
                    {
                        case "short":
                            parameterDescription.Type = typeof(short);
                            break;
                        case "string":
                            parameterDescription.Type = typeof(string);
                            break;
                        case "int":
                            parameterDescription.Type = typeof(int);
                            break;
                        default:
                            System.Diagnostics.Debug.WriteLine("loadFuncParam() Parameter Type error. {0}_{1}", excelData[row, col], excelData[row, col + 1]);
                            continue;
                    }

                    parameterDescription.Name = excelData[row, col + 1];

                    parameterTypes[excelData[row, 0]].Add(parameterDescription);
                }
            }

            _funcParameter.SetMethodParameters(parameterTypes);
        }
    }
}
