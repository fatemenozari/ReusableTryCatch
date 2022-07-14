using System;
using System.Collections.Generic;

namespace ReusableTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HandlingUserActions.DoTry(() => UserRepository.AddUser(" Stafen ", 0));
            HandlingUserActions.DoTry(() => UserRepository.AddUser(" Elena ", 122));

            foreach (var User in UserRepository.UserList)
              Console.WriteLine($" Username : {User.UserName}  PassWord : {User.Password}");

            Console.ReadKey();
        }
    }

    
}
