using System;
using System.Collections.Generic;

namespace ReusableTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            HandlingUserActions.DoTry(() => user.AddUser("faezeh", 122));
            HandlingUserActions.DoTry(() => user.AddUser("Fateme", 123));

            foreach (var User in user.UserList)
              Console.WriteLine($"Username : {User.UserName} PassWord : {User.Password}");

            Console.ReadKey();
        }
    }

    
}
