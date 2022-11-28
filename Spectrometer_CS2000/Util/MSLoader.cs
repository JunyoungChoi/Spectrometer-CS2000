using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spectrometer_CS2000.Util
{
    class MSLoader
    {
        public static Assembly GetInstance(string instanceName)
        {
            Assembly asm = null;

            //Dll이 있는지 여부
            if (false == File.Exists(instanceName))
            {   //없으면 에러
                return asm;
            }

            //Dll 로드
            //Assembly asm = Assembly.LoadFrom(sFileName);
            asm = Assembly.LoadFrom(instanceName);

            //로드가 되었나?
            if (asm == null)
            {
                return asm;
            }

            return asm;
        }
        public static object GetHandler(Assembly asm)
        {
            //로드가되었으면 
            //Dll에 소속된 구성요소 리스트를 받아온다.
            Type[] types = asm.GetExportedTypes();
            Type typeOfHandler = null;

            foreach (Type t in types)
            {
                if (t.Name.Equals("ServiceHandler"))
                {
                    typeOfHandler = t;
                    break;
                }
            }

            object handler = Activator.CreateInstance(typeOfHandler);

            return handler;
        }

        public static Form GetFormOf(Assembly asm, string formName)
        {
            Form f = null;

            //로드가되었으면 
            //Dll에 소속된 구성요소 리스트를 받아온다.
            Type[] types = asm.GetExportedTypes();

            foreach (Type t in types)
            {
                if (t.Name.Equals(formName))
                {
                    object ob = Activator.CreateInstance(t);
                    f = ob as Form;

                    return f;
                }
            }

            return f;
        }
    }
}
