using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    //1.	User Management:
    //o User class with UserID, Name, Email, and methods for Register, Login, ViewProfile.
    //o Secure password storage and authentication.
    class User
    {
        internal int UserID { get; set; }
        internal string UserName { get; set; }
        internal string UserEmail { get; set; }
        internal string Password { get; set; }
        internal UserRoles UserRole { get; set; }

        public User(int userID, string userName, string userEmail, string password,UserRoles role)
        {
            UserID = userID;
            UserName = userName;
            UserEmail = userEmail;
            Password = password;
            UserRole = role;
        }

        public bool VerifyPassword(string password)
        {
            return Password.Equals(password);
        }
    }
}
