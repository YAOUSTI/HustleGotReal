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
    class WebDriverClass
    {
        IWebDriver driver;

        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\3rdparty\\chrome");
        }
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}
