using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HustleGotReal
{
    class SelectValue
    {

        IWebDriver m_driver;

        public string selectValue()
        {
            m_driver = new ChromeDriver("G:\\");
            m_driver.Url = "https://app.hustlegotreal.com";
            m_driver.Manage().Window.Maximize();

            //page Home is empty without any output
            IWebElement value = m_driver.FindElement(By.Id("NoOutputFounded"));

            //var selectTest = new SelectElement(value);
            // Select a value from the label			
            //selectTest.SelectByValue("sap-abap");
            return value.ToString();
        }

    }
}
