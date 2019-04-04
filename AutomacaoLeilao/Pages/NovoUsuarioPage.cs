using OpenQA.Selenium;

namespace AutomacaoLeilao.Pages
{
    public class NovoUsuarioPage
    {
        IWebDriver driver;

        public NovoUsuarioPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Cadastra(string nome, string email)
        {
            IWebElement nomeDoUsuario = driver.FindElement(By.Name("usuario.nome"));
            IWebElement emailDoUsuario = driver.FindElement(By.Name("usuario.email"));

            nomeDoUsuario.SendKeys(nome);
            emailDoUsuario.SendKeys(email);

            nomeDoUsuario.Submit();
        }
    }
}
