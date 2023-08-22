using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkInheritance
{
    class Lecturer : Person
    {
        private string qualification;
        private string[] classes;
        public Lecturer(string name, string surname, string gender, int age, string qualification, string[] classes) : base(name, surname, gender, age)
        {
            this.Qualification = qualification;
            this.Classes = classes;
        }

        public string Qualification { get => qualification; set => qualification = value; }
        public string[] Classes { get => classes; set => classes = value; }

        public override void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Qualification: " +Qualification);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Age: " + Age);
            for (int i = 0; i < Classes.Length; i++)
            {
                int count = i + 1;
                Console.WriteLine("Subject " + count + ": " + Classes[i]);
            }
        }
    }
}
