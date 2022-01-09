using Exceptions.Constans;
using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Auth
{
    public class Account
    {
        public string userName, password;
        

       

        public void Login(string userName, string password)
        {
            try
            {

                if (password.Length >6 )
                {
                    Console.WriteLine("Login was success");
                    return;
                }

                Console.WriteLine(Messages.LoginMessageFalse);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something is wrong"); 
            }
        }
    }
}
