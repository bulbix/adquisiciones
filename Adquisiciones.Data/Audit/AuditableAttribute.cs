using System;

namespace Adquisiciones.Data.Audit
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    [Serializable]
    public class AuditableAttribute : Attribute
    {
    }
}
