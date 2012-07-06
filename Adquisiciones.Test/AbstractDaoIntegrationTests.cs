using Spring.Testing.NUnit;

namespace Adquisiciones.Test
{
    public class AbstractDaoIntegrationTests : AbstractTransactionalDbProviderSpringContextTests
    {

        protected override string[] ConfigLocations
        {
            get
            {
                return new string[]
                    {
                        "assembly://Adquisiciones.Data/Adquisiciones.Data.Dao/Dao.xml",
                        "assembly://Adquisiciones.Business/Adquisiciones.Business/Services.xml"
                    };
            }
        }
    }
}
