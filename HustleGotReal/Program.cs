using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustleGotReal
{
    class Program
    {
        static void Main(string[] args)
        {
            WebDriverClass launch = new WebDriverClass();
            launch.startBrowser();
            LoginCredentials login = new LoginCredentials();
            login.Login();
            SelectValue value = new SelectValue();
            value.selectValue();
            Console.WriteLine(value);
            launch.closeBrowser();
        }
    }
}
