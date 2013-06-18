using System;
using Adquisiciones.Business;
using Adquisiciones.Business.Seguridad;
using Adquisiciones.Data.Dao.Seguridad;
using Adquisiciones.Data.Entities;
using NUnit.Framework;

namespace Adquisiciones.Test.Seguridad
{
    [TestFixture]
    public class UnitTestUsuario : AbstractDaoIntegrationTests
    {

        public IUsuarioService UsuarioService { get; set; }


        public IUsuarioDao UsuarioDao { private get; set; }

        [Test]
        public void TestGuardarUsuario()
        {
            var usuario = new Usuario();
            usuario.Rfc = "POOO000000";
            usuario.Nombre = "Ronaldo";
            usuario.Password = "garbage";
            //var um = new UsuarioModulo();
            //usuario.UsuarioModulo.Add();


        }

        [Test]
        public void TestMethodAccess(){
            var usuario = UsuarioDao.ConsultarUsuario("SAIH940101", Util.GetSHA1("bulbo"));
            Assert.AreEqual("SUPERINR", usuario.Nombre);
           //Assert.AreEqual(2, usuario.UsuarioModulo.Count);
        }



        [Test]
        public void TestGetPassword()
        {
            var pass = Util.GetSHA1("ergar");
            Console.WriteLine(pass);

        }

    }
}
