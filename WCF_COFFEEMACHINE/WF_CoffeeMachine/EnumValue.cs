using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace WF_CoffeeMachine
{
    class EnumValue : System.Attribute
    {
        private string _value;
        public EnumValue(string value)
        {
                _value = value;
        }
        public string Value
        {
            get { return _value; }
        }

            public static string GetStringValue(Enum value)
            {
                string output = null;
                Type type = value.GetType();

                //Check first in our cached results...

                //Look for our 'StringValueAttribute' 

                //in the field's custom attributes

                FieldInfo fi = type.GetField(value.ToString());
                EnumValue[] attrs =
                   fi.GetCustomAttributes(typeof(EnumValue),false) as EnumValue[];
                if (attrs.Length > 0)
                {
                    output = attrs[0].Value;
                }

                return output;
            
        }
    }
}
