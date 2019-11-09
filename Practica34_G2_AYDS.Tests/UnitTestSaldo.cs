using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica34_G2_AYDS.Tests
{
    [TestClass]
    public class UnitTestSaldo
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void consultaSaldoTest()
        {
            consultaSaldo saldo = new consultaSaldo();
            string resultado = saldo.returnSaldo("1234");
            Assert.Equals(resultado, "");
        }
    }
}
