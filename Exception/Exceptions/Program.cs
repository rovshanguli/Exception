using Exceptions.Auth;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Account account = new Account();

            account.Login("Rovshan", "123");
            account.Login("Javid", "Bashirov123");
        }
    }
}
