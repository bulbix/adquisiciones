using Adquisiciones.Business;
using Adquisiciones.Data.Dao.Catalogos;
using NUnit.Framework;


namespace Adquisiciones.Test.Proveedores
{
    [TestFixture]
    public class UnitTestProveedor : AbstractDaoIntegrationTests
    {
        public IProveedorDao ProveedorDao { private get; set; }

        [Test]
        public void TestConsultaProveedor()
        {
            var proveedor = ProveedorDao.Get(1);
            Assert.AreNotEqual("sadsad", proveedor.Rfc);

            var proveedores = ProveedorDao.FindAll();
            Assert.AreEqual(411, proveedores.Count);
        }

          [Test]
        public void TestValidaProveedor()
        {
            var proveedor = ProveedorDao.Get(415);
            Assert.True(Util.DatosValidos(proveedor, null, null));


        }


    }
}
