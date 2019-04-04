using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using AutomacaoLeilao.Pages;

namespace AutomacaoLeilao.Testes
{
    [TestFixture]
    class UsuarioSystemTest
    {
        private UsuarioPage usuarios;

        public UsuarioSystemTest()
        {
            IWebDriver driver = new FirefoxDriver();
            usuarios = new UsuarioPage(driver);
        }
        [Test]
        public void cadastrarUsuario()
        {
            usuarios.Visita();
            usuarios.Novo().Cadastra("Helen Oliver", "helenoliversil@gmail.com");

            Assert.IsTrue(usuarios.ExisteNaListagem("Helen Oliver", "helenoliversil@gmail.com"));

        }
    }
}
