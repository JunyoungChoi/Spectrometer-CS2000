using ISSOFT.Util;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectrometer_CS2000.Entity
{
    class FuncParameter
    {
        /// <summary>
        /// Key : Function 이름
        /// Value : Parameter 이름, 타입, 데이터
        /// </summary>
        private Dictionary<string, List<ParameterDescription>> _parameterDescription;

        /// <summary>
        /// Key : Function 이름
        /// Value : Parameter 이름, 타입, 데이터
        /// </summary>
        public Dictionary<string, List<ParameterDescription>> ParameterDescription { get { return this._parameterDescription; } }

        public FuncParameter()
        {
            _parameterDescription = new Dictionary<string, List<ParameterDescription>>();
        }

        public void SetMethodParameters(Dictionary<string, List<ParameterDescription>> parameterDescription)
        {
            this._parameterDescription = parameterDescription;
        }
    }

    // 나중에 제네릭으로 자동 타입변환을 해보고 싶군
    class Parameter : ParameterDescription
    {
        public object Value { get; private set; }

        public Parameter(string name, object value) : base(name, value.GetType())
        {
            this.Value = value;
        }

        public void SetValue(object value)
        {
            base.Type = value.GetType();
            this.Value = value;
        }

    }

    class ParameterDescription
    {
        public string Name = string.Empty;
        public Type Type = null;

        public ParameterDescription(string name, Type type)
        {
            this.Name = name;
            this.Type = type;
        }

        public ParameterDescription()
        {

        }
    }
}
