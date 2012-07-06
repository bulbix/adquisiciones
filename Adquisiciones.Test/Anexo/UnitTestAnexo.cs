using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Data.Entities;
using NUnit.Framework;

namespace Adquisiciones.Test.Anexo
{
    [TestFixture]
    public class UnitTestAnexo:AbstractDaoIntegrationTests
    {
        public IAnexoService AnexoService { private get; set; }

        [Test]
        public void TestConsultaAnexo()
        {
            Assert.IsNotNull(AnexoService.ConsultarAnexo("anexo3", new Almacen("C5")));
        }

     

        [Test]
        public void TestGuardarAnexo()
        {
            //var anexo = new Anexo();

            //anexo.DesAnexo = "Lola";
            //Assert.NotNull(anexo.AnexoDetalle[0].Id);
            //Assert.AreEqual(3, anexo.AnexoDetalle.Count);
            //anexo.AnexoDetalle.RemoveAt(0);
            //anexo = AnexoService.GuardarAnexo(anexo);
            //Assert.AreEqual(2, anexo.AnexoDetalle.Count);

        }


        [Test]
        public void TestActualizarAnexo()
        {
            var anexo = AnexoService.ConsultarAnexo("aaaa", new Almacen("C5"));
            anexo.DesAnexo = "Lola";
            //AnexoService.GuardarAnexo(ref anexo);
            Assert.AreEqual(0, anexo.AnexoDetalle.Count);

        }

        [SetUp]
        public void SetUp()
        {
            base.SetComplete();
        }

        [TearDown]
        public void TearDown()
        {  
        }
    }
}
