using NHibernate.Bytecode;
using Spring.Data.NHibernate.Bytecode;
using Spring.Data.NHibernate;

namespace Adquisiciones.Data.Dao
{
    public class CustomLocalSessionFactory : LocalSessionFactoryObject
    {
      
        public override IBytecodeProvider BytecodeProvider
        {

            get
            {
               
                return new BytecodeProvider(ApplicationContext);
            }
            set { }
        }




    }
}
