using System;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Dao.ModAnexo;
using NUnit.Framework;

namespace Adquisiciones.Test.Fallo
{
    [TestFixture]
    public class UnitTestFallo : AbstractDaoIntegrationTests
    {
        public IFalloService FalloService { private get; set; }
        public IAnexoDao AnexoDao { private get; set; }

        [Test]
        public void TestMethodGenerarFallo()
        {
            var anexo = AnexoDao.Get(3);
            var fallos = FalloService.GenerarFallo(anexo, new DateTime());
            Assert.IsNotNull(fallos);
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
