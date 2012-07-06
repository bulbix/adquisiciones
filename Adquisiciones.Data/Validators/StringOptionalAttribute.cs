using System;
using Adquisiciones.Data.Validators;
using NHibernate.Validator.Engine;

namespace Adquisiciones.Data
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    [ValidatorClass(typeof(StringOptionalValidator))]
    public class StringOptionalAttribute : Attribute, IRuleArgs
    {
            private string _message = "Solo se aceptan letras con puntos y comas";

            public string Message
            {
                get { return _message; }
                set { _message = value; }
            }
     
    }
}
