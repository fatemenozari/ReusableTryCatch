using System.Collections.Generic;

namespace ReusableTryCatch
{
    internal class User
    {
        public string UserName;
        public int Password;
        public List<User> UserList = new List<User>();

        public void AddUser(string userName, int password)
        {
            User user = new User
            {
                UserName = userName,
                Password = password
            };

            UserList.Add(user);
        }


    }
}
