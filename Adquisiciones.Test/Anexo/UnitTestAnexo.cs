using Adquisiciones.Business;
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
        public void TestConstruirHistorico()
        {
            
            //Util.ConstruirHistorico()
        }

        [Test]
        public void TestConsultaAnexo()
        {
            Assert.IsNotNull(AnexoService.ConsultarAnexo("anexo3", new Almacen("C5")));
        }

        [Test]
        public void TestFechaServidor()
        {
           Assert.NotNull(AnexoService.AnexoDao.FechaServidor());
        }

        [Test]
        public void TestGuardarAnexo()
        {
            var anexo = new Data.Entities.Anexo();
            anexo.NumeroAnexo = "anexoprueba";
            anexo.DesAnexo = "Lola";
            AnexoService.GuardarAnexo(ref anexo);
            Assert.NotNull(anexo.IdAnexo);

        }


        [Test]
        public void TestActualizarAnexo()
        {
            var anexo = AnexoService.ConsultarAnexo("pruebaho", new Almacen("C5"));
            anexo.DesAnexo = "Lola2";
            AnexoService.GuardarAnexo(ref anexo);
            Assert.AreEqual(anexo.DesAnexo, "Lola2");
        }

        [SetUp]
        public void SetUp()
        {
            base.SetComplete();
        }

        //[TearDown]
        //public void TearDown()
        //{
        //}
    }
}
