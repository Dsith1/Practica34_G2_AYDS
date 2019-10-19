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
        public void Tranferencia_Exitosa()
        {
            Transferencia transferir = new Transferencia();
            string cuentaSale = "1";
            string cuentaentra = "2";

            int monto = 1000;
            int saldo1 = transferir.getSaldo(cuentaSale);
            int saldo2 = transferir.getSaldo(cuentaSale);

            string resultado = transferir.transferir(cuentaSale, cuentaentra, monto,saldo1,saldo2);

            Assert.Equals(resultado, "Transferencia Realizada");
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
