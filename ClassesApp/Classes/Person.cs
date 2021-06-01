using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Gender { get; set; }

        public Person()
        {
            Console.WriteLine("Создан пустой экземпляр класса Person");
        }

        public Person(string name, string lastName, DateTime birthDay, int heigh, int weight, string gender)
        {
            Name = name;
            LastName = lastName;
            BirthDay = birthDay;
            Height = heigh;
            Weight = weight;
            Gender = gender;

            Console.WriteLine($"Создан экземпляр класса Person со значениями {Name}, {LastName}, {BirthDay}, {Height}, {Weight}, {Gender}");
        }

        public void GetPersonData()
        {
            Console.WriteLine(Name);
            Console.WriteLine(LastName);
            Console.WriteLine(Convert.ToString(BirthDay));
            Console.WriteLine(Convert.ToString(Height));
            Console.WriteLine(Convert.ToString(Weight));
            Console.WriteLine(Convert.ToString(Gender));
            Console.ReadKey();
        }
    }
}
