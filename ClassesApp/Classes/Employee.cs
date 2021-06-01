using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp.Classes
{
    class Employee : Person
    {
        public string ProfessionName { get; set; }
        public string Qualification { get; set; }
        public string NameOfCompany { get; set; }
        public bool IsFired { get; set; }

        public Employee()
        {
            Console.WriteLine("Создан пустой экземпляр класса Employee");
        }

        public Employee(string professionName, string qualification, string nameOfCompany, bool isFired)
        {
            ProfessionName = professionName;
            Qualification = qualification;
            NameOfCompany = nameOfCompany;

            if (IsFired == false)
            {
                Console.WriteLine($"Создан экземпляр класса Employee со значениями {ProfessionName}, {Qualification}, {NameOfCompany}, Работает");
            }
            else
            {
                Console.WriteLine($"Создан экземпляр класса Employee со значениями {ProfessionName}, {Qualification}, {NameOfCompany}, Уволен");
            }
        }

        public void WorkerGetJob(string CompanyName)
        {
            NameOfCompany = CompanyName;
            IsFired = false;
        }

        public void WorkerFired()
        {
            NameOfCompany = null;
            IsFired = true;
        }

        public void GetWorkerData()
        {
            if (IsFired == false)
            {
                Console.WriteLine(ProfessionName);
                Console.WriteLine(Qualification);
                Console.WriteLine(NameOfCompany);
                Console.WriteLine("Работник работает");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(ProfessionName);
                Console.WriteLine(Qualification);
                Console.WriteLine("Работник уволен");
                Console.ReadKey();
            }
        }
    }
}
