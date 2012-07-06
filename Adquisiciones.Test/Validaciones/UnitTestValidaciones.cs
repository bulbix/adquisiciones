using Adquisiciones.Data.Entities;
using Adquisiciones.Business;
using NUnit.Framework;


namespace Adquisiciones.Test.Validaciones
{
    [TestFixture]
    public class UnitTestValidaciones
    {
        [Test]
        public void TestMethodValProveedor()
        {
            var proveedor = new Proveedor()
            {
                Calle = "Napoles 25", Nombre = "Luis Prado"
            };

            var valido = Util.DatosValidos<Proveedor>(proveedor);
            Assert.IsFalse(valido,"Proveedor debe ser valido");

            proveedor.Calle = "sadasd";//string.Empty;
            proveedor.Nombre = "";//"Luis Prado";
            valido = Util.DatosValidos<Proveedor>(proveedor);
 
            Assert.IsFalse(valido, "Falta Calle");
            //Assert.IsFalse(valido, "Falta ");

        }
    }
}
