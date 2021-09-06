using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HustleGotReal
{
    class LoginCredentials
    {
        IWebDriver m_driver;
        public void Login()
        {
            m_driver = new ChromeDriver("G:\\");
            m_driver.Url = "https://app.hustlegotreal.com/Account/Login";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = m_driver.FindElement(By.Id("Email"));
            IWebElement passwordTextBox = m_driver.FindElement(By.Id("Password"));
            IWebElement signUpButton = m_driver.FindElement(By.ClassName("btn btn-primary btn-wide"));

            emailTextBox.SendKeys("testing@hustlegotreal.com");
            passwordTextBox.SendKeys("HGR2021");
            signUpButton.Click();

        }
    }
}
