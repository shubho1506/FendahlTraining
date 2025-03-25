using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ClassLibraryInCSharp;

namespace ConfigInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = ConfigurationManager.AppSettings["Username"];
            string password = ConfigurationManager.AppSettings["Password"];
            string clientFilePath = ConfigurationManager.AppSettings[ClassFeildHelper.FilePath];

            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"ClientFileDll: {clientFilePath}");
        }
    }
}
