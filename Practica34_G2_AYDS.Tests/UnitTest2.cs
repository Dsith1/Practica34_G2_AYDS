using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Practica34_G2_AYDS.Tests
{
    [TestClass]
    public class UnitTest2
    {

        public IWebDriver Navegador;
        public string ruta = "https://localhost:44302/ConsumoWeb";

        [TestMethod]
        public void Prueba_Selenium_Consumo_Web()
        {
            ChromeOptions chome_opciones = new ChromeOptions();
            chome_opciones.AddAdditionalCapability("useAutomationExtension", false);
            Navegador = new ChromeDriver(chome_opciones);
            Navegador.Navigate().GoToUrl(ruta);
            Navegador.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            IWebElement btnCambioDia = Navegador.FindElement(By.Id("Button1"));
            btnCambioDia.Click();
            IWebElement txtDesde = Navegador.FindElement(By.Id("txtDiaInicio"));
            txtDesde.SendKeys("5/11/19");
            btnCambioDia = Navegador.FindElement(By.Id("Button2"));
            btnCambioDia.Click();

          //  txtDesde.SendKeys("Funcionnó Selenium");

        }


        [TestInitialize()]
        public void Setup_Web()
        {

        }

        [TestCleanup()]
        public void Limpiar_Prueba()
        {
           //Navegador.Close();
        }
    }
}
