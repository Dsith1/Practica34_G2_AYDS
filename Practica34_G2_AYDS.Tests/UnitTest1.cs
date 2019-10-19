using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica34_G2_AYDS.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void IniciarSesionPruebaCorrecta()
        {
            IniciarSesion iniciar = new IniciarSesion();
            string resultado = iniciar.Login("hil@gmail.com", "123");
            Assert.Equals(resultado, "Correcto");
        }

        [TestMethod]
        public void RegistroCorrecto()
        {
            IniciarSesion iniciar = new IniciarSesion();
            int resultado = iniciar.RegistrarUsuario("1222222222222222","Carlos Joaquin", "Perez Miranda","carlos@gmail.com","hola");
            Assert.AreEqual(resultado, 1);
        }
    }
}
