﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoLeilao.Pages
{
    public class UsuarioPage
    {
        IWebDriver driver;

        public UsuarioPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Visita()
        {
            driver.Navigate().GoToUrl("http://localhost:8080/usuarios/new");
        }

        public NovoUsuarioPage Novo()
        {
            driver.FindElement(By.LinkText("Novo Usuário")).Click();
            return new NovoUsuarioPage(driver);
        }

        public bool ExisteNaListagem(string nome, string email)
        {
            bool achouNome = driver.PageSource.Contains(nome);
            bool achouEmail = driver.PageSource.Contains(email);

            return achouNome && achouEmail;
        }
    }
}
