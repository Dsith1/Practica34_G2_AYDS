using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica34_G2_AYDS.Tests
{
    [TestClass]
    public class VerPerfilTest
    {
        [TestMethod]
        public void obtenerPerfilUsuarioCorrectoShouldReturnTrue()
        {
            VerPerfil perfil = new VerPerfil();
            Boolean mi_perfil=perfil.obtenerPerfil("sergio@gmail.com");

            Assert.IsTrue(mi_perfil);
        }

        [TestMethod]
        public void obtenerPerfilUsuarioIncorrectoShouldReturnFalse()
        {
            VerPerfil perfil = new VerPerfil();
            Boolean mi_perfil = perfil.obtenerPerfil("pedro");

            Assert.IsFalse(mi_perfil);
        }
    }
}
