using Adquisiciones.Data.Entities;
using NHibernate.Validator.Engine;

namespace Adquisiciones.Data.Validators
{
    class GroupAndValidator:IInitializableValidator<GroupAndAttribute>
    {
        public void Initialize(GroupAndAttribute parameters)
        {
        }

        public bool IsValid(object value, 
            IConstraintValidatorContext constraintValidatorContext)
        {
            var objeto = value as CotizacionDetalle;

            if (objeto.Precio == null && string.IsNullOrEmpty(objeto.Marca))
                return true;

            if (objeto.Precio != null && !string.IsNullOrEmpty(objeto.Marca))
                return true;

            return false;}
    }
}
