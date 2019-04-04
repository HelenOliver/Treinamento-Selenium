using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace AutomacaoLeilao.Testes
{
    [TestFixture]
    class UsuarioSystemTest
    {
        [Test]
        public void cadastrarUsuario()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:8080/usuarios/new");

            IWebElement campoNome = driver.FindElement(By.Name("usuario.nome"));
            IWebElement campoEmail = driver.FindElement(By.Name("usuario.email"));
            IWebElement btnSalvar = driver.FindElement(By.Id("btnSalvar"));

            campoNome.SendKeys("Helen Oliver");
            campoEmail.SendKeys("helenoliversil@gmail.com");

            btnSalvar.Click();

            bool achouNome = driver.PageSource.Contains("Helen Oliver");
            bool achouEmail = driver.PageSource.Contains("helenoliversil@gmail.com");

            Assert.IsTrue(achouNome);
            Assert.IsTrue(achouEmail);

            //driver.Close();

        }



    }
}
