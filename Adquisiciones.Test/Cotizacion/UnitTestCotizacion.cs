using System;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Data.Entities;
using NUnit.Framework;

namespace Adquisiciones.Test.Anexo
{
    [TestFixture]
    public class UnitTestCotizacion:AbstractDaoIntegrationTests
    {
        public ICotizacionService CotizacionService { private get; set; }

        [Test]
        public void TestConsultaAnexoFallo()
        {  
            var anexo = CotizacionService.AnexoDao.Get(1);

            Assert.True(CotizacionService.CotizacionDao.ExisteAnexoFallo(anexo));
            
        }

        [Test]
        public void TestMaximoId()
        {
            var max  =
            CotizacionService.CotizacionDao.MaximoId(new Almacen("DE"));

            Assert.AreEqual(1,max);

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
