using System.Text.RegularExpressions;
using NHibernate.Validator.Engine;

namespace Adquisiciones.Data.Validators
{
    class StringOptionalValidator : IInitializableValidator<StringOptionalAttribute>
    {
        private Regex _regex;

        public bool IsValid(object value, IConstraintValidatorContext constraintContext)
        {
            if (value == null || value.ToString().Equals(""))
                return true;

            return _regex.IsMatch(value.ToString());
        }

        public void Initialize(StringOptionalAttribute parameters)
        {
            _regex = new Regex(@"^[a-zA-Z]+(\,*\.*\s*[a-zA-Z]*)*[a-zA-Z]+$");
        }
    }
}
