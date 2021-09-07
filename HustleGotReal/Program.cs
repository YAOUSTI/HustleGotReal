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
            LoginCredentials login = new LoginCredentials();
            login.Launch(); 
            login.Login(); 
            Console.WriteLine(login.Value());
        }
    }
}
