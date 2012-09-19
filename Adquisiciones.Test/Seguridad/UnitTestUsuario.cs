using System;
using Adquisiciones.Business;
using Adquisiciones.Data.Dao.Seguridad;
using NUnit.Framework;

namespace Adquisiciones.Test.Seguridad
{
    [TestFixture]
    public class UnitTestUsuario : AbstractDaoIntegrationTests
    {
        public IUsuarioDao UsuarioDao { private get; set; }

        [Test]
        public void TestMethodAccess(){
            var usuario = UsuarioDao.AccessAllow("BULBIX", "adios");
            Assert.AreEqual("bulbo", usuario.Nombre);
            Assert.AreEqual(2, usuario.UsuarioModulo.Count);
        }



        [Test]
        public void TestGetPassword()
        {
            var pass = Util.GetSHA1("tibro");
            Console.WriteLine(pass);

        }

    }
}
