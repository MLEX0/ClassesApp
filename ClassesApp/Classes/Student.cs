using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp.Classes
{
    class Student : Person
    {
        public string CollegeName { get; set; }
        public string GroupName { get; set; }
        public bool IsExpelled { get; set; }

        public Student()
        {
            Console.WriteLine("Создан пустой экземпляр класса Student");
        }

        public Student(string collegeName, string groupName, bool isEcpelled)
        {
            CollegeName = collegeName;
            GroupName = groupName;
            IsExpelled = isEcpelled;

            if (IsExpelled == false)
            {
                Console.WriteLine($"Создан экземпляр класса Student со значениями {CollegeName}, {GroupName}, Учится");
            }
            else
            {
                Console.WriteLine($"Создан экземпляр класса Student со значениями {CollegeName}, {GroupName}, Отчислен");
            }
        }

        public void StudentEnroll ()
        {
            IsExpelled = false;
        }

        public void StudentExpel()
        {
            IsExpelled = true;
        }

        public void GetStudentData()
        {
            if (IsExpelled == false)
            {
                Console.WriteLine(CollegeName);
                Console.WriteLine(GroupName);
                Console.WriteLine("Студент учится");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(CollegeName);
                Console.WriteLine(GroupName);
                Console.WriteLine("Студент отчислен");
                Console.ReadKey();
            }
        }
    }
}
