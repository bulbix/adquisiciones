using System;
using NHibernate.Validator.Engine;

namespace Adquisiciones.Data.Validators
{
    [AttributeUsage(AttributeTargets.Class)]
    [ValidatorClass(typeof(GroupAndValidator))]
    public class GroupAndAttribute : Attribute, IRuleArgs
    {
        private string _message = "Debe capturar todo el renglon";

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

       
    }
   
}
