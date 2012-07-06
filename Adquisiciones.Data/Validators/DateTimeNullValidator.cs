using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Validator.Engine;

namespace Adquisiciones.Data.Validators
{
    class DateTimeNullValidator : IInitializableValidator<DateTimeNullAttribute>
    {
        public void Initialize(DateTimeNullAttribute parameters)
        {
            //throw new NotImplementedException();
        }

        public bool IsValid(object value, IConstraintValidatorContext constraintValidatorContext)
        {


            bool result = true;

            if (value == null || value.ToString().Equals("01/01/0001 12:00:00 a.m."))
                result =  false;

            return result;
        }
    }
}
