using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Alone
{
    public sealed class Authenticator
    {
        private static Authenticator _instance;
        private Authenticator() { }

        public static Authenticator GetInstance()
        {
           
            if (_instance == null)
            {
                _instance = new Authenticator();
            }
            return _instance;
        }

        public void Authenticate()
        {
            Console.WriteLine("Екзимпляр успішно створено!");
        }
    }
}
