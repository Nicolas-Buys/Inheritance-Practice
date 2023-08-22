using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkInheritance
{
    class Student : Person
    {
        private string studentnumber;
        private string[] subjects;

        public Student(string name, string surname, string gender, int age, string studentnumber, string[] subjects) : base(name, surname, gender, age)
        {
            this.Studentnumber = studentnumber;
            this.Subjects = subjects;
        }

        public string Studentnumber { get => studentnumber; set => studentnumber = value; }
        public string[] Subjects { get => subjects; set => subjects = value; }

        public override void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("StudentID: " + Studentnumber);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Age: " + Age );
            for (int i = 0; i < Subjects.Length; i++)
            {
                int count = i + 1;
                Console.WriteLine("Subject "+count+": "+Subjects[i]);
            }
        }
    }
}
