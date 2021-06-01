using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesApp.Classes;

namespace ClassesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.GetPersonData();

            Person roma = new Person("Ромочка", "Исаков", Convert.ToDateTime("01.01.2004"), 170, 75, "мужской");
            roma.GetPersonData();

            Student student = new Student();
            student.GetStudentData();

            Student misha = new Student("ОКГ Столица","49057-В", false);
            misha.GetStudentData();

            Employee employee = new Employee();
            employee.WorkerFired();
            employee.GetWorkerData();

            Employee edik = new Employee("Программист", "Колледж связи 54", "ООО МОЯ ОБОРОНА", false);
            edik.GetWorkerData();

            User user = new User();
            user.GetUserData();

            User degrod = new User("WalkingDegrodation1337","12345");
            degrod.GetUserData();

        }
    }
}
