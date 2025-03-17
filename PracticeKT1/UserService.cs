using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    class UserService
    {
        List<User> users = new List<User>();
        static int userID = 101;
        public void RegisterUser(string username,string email,string password,UserRoles role)
        {
            users.Add(new User(userID++, username, email, password, role));
            Console.WriteLine("User Successfully Registered !!!");
        }

        public User LoginUser(string email, string password)
        {
            var user = users.Find(u => u.UserEmail == email && u.VerifyPassword(password));
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            Console.WriteLine($"Welcome {user.UserName}!");
            return user;
        }

        public void ViewUserProfile(int id)
        {
            var profile = users.Find(a => a.UserID == id);

            Console.WriteLine("Profile : \n"+
                $"User Id : {profile.UserID}\n"+
                $"User Name : {profile.UserName}\n"+
                $"User Email : {profile.UserEmail}\n"+
                $"User Role : {profile.UserRole}\n");
        }
    }
}
