using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableTryCatch
{
    internal class HandlingUserActions
    {
        public static void DoTry(Action userAction)
            {
                try
                {
                    userAction();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    
}
