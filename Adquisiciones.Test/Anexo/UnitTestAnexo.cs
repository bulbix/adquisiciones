using Adquisiciones.Business;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Data.Dao;
using Adquisiciones.Data.Entities;
using NUnit.Framework;

namespace Adquisiciones.Test.Anexo
{
    [TestFixture]
    public class UnitTestAnexo:AbstractDaoIntegrationTests
    {
        public IAnexoService AnexoService { private get; set; }

        public IObjectDao ObjectDao { private get; set; }

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
            anexo.NumeroAnexo = "anexoprueba44";
            anexo.DesAnexo = "Lola";
            AnexoService.GuardarAnexo(ref anexo);
            Assert.NotNull(anexo.IdAnexo);

        }

        [Test]
        public void TestAnexoHist()
        {
            var nombreTabla = "AnexoHist";
            var idPadre = 12;
            Assert.AreEqual(15,ObjectDao.GetIdHistorico(nombreTabla, idPadre));

        }


        [Test]
        public void TestActualizarAnexo()
        {
            var anexo = AnexoService.ConsultarAnexo("nena", new Almacen("C5"));
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
