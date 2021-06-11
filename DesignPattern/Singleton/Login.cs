using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Login
    {
        private static Login instance = new Login();
        string user = "taikhoan";
        string pass = "matkhau";

        private Login()
        {
        }
        public static Login getInstance()
        {
            return instance;
        }
        public void checkUser(string username, string password)
        {
            do
            {
                if (username == user && password == pass) { }          
                else
                {
                    Console.WriteLine("Wrong please type again");
                    Console.WriteLine("Type Username");
                    username = Console.ReadLine();
                    Console.WriteLine("Type Password");
                    password = Console.ReadLine();
                }
            } while (username != user && password != pass);
            Console.WriteLine("Login successful");
        }
    }
}
