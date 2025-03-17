using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    class UserNotFoundException : Exception
    {
        public UserNotFoundException()
        {
            Console.WriteLine("User Not Found !!! Please check your email or password.");
        }
    }
}
