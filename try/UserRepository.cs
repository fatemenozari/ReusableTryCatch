using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableTryCatch
{
    internal static class UserRepository
    {
        public static List<User> UserList = new List<User>();

        public static void AddUser(string userName, int password)
        {
            User user = new User
            {
                UserName = userName,
                Password = password 
            };

            if (userName == null || userName == " " || password <= 0)
                throw new ArgumentException(" userName or password is null  ");

            else
                UserList.Add(user);
        }

    }

}
