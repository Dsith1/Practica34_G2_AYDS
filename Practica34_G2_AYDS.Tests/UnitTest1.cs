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
        
    }
}
