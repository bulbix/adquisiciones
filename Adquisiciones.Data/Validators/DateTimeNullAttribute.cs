using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Validator.Engine;

namespace Adquisiciones.Data.Validators
{

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    [ValidatorClass(typeof(DateTimeNullValidator))]
    public class DateTimeNullAttribute : Attribute, IRuleArgs
    {
        private string _message = "Fecha no esta seleccionada";

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
     
    }
}
