using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp.Classes
{
    class User : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {
            Console.WriteLine("Создан пустой экземпляр класса User");
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;

            Console.WriteLine($"Создан экземпляр класса User со значениями {Login}, {Password}");
        }

        public void GetUserData()
        {
            Console.WriteLine(Login);
            Console.WriteLine(Password);
            Console.ReadKey();
        }
    }
}
