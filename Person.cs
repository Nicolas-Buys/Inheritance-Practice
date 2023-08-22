using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkInheritance
{
    class Person
    {
        private string name, surname, gender;
        int age;

        public Person(string name, string surname, string gender, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }

        public virtual void Display()
        {

        }
    }
}
