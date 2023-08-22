using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkInheritance
{
    class Program
    {
        enum Menu
        {
            AddStudent = 1,
            AddLecturer,
            Display, 
            Exit
        }
        static void Main(string[] args)
        {
            bool cont = true;
            List<Student> Students = new List<Student>();
            List<Lecturer> lecturers = new List<Lecturer>();
            while(cont == true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Lecturer");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch ((Menu)choice)
                {
                    case Menu.AddStudent:
                        CreateStudents(Students);
                        break;
                    case Menu.AddLecturer:
                        CreateLecturers(lecturers);
                        break;
                    case Menu.Display:
                        foreach (var item in Students)
                        {
                            item.Display();
                        }
                        foreach (var item in lecturers)
                        {
                            item.Display();
                        }
                        Console.ReadKey();
                        break;
                    case Menu.Exit:
                        cont = false;
                        break;
                }
            }
        }
        static string[] AddInheritInfo()
        {
            string[] Details = new string[4];
            Console.WriteLine("Name: ");
            Details[0] = Console.ReadLine();
            Console.WriteLine("Surname: ");
            Details[1] = Console.ReadLine();
            Console.WriteLine("Gender: ");
            Details[2] = Console.ReadLine();
            Console.WriteLine("Age: ");
            Details[3] = Console.ReadLine();
            return Details;
        }
        static List<Student> CreateStudents(List<Student> students)
        {
            string[] Details = AddInheritInfo();
            Console.WriteLine("StudentID: ");
            string StudentNumber = Console.ReadLine();
            string[] subjects = new string[7];
            for (int i = 0; i < subjects.Length; i++)
            {
                int count = i + 1;
                Console.WriteLine("Subject " + count + "of 7: ");
                subjects[i] = Console.ReadLine();
            }
            Student student = new Student(Details[0], Details[1], Details[2], int.Parse(Details[3]), StudentNumber, subjects);
            students.Add(student);
            return students;
        }
        static List<Lecturer> CreateLecturers(List<Lecturer> lecturers)
        {
            string[] Details = AddInheritInfo();
            Console.WriteLine("Qualification: ");
            string Qualification = Console.ReadLine();
            string[] Classes = new string[7];
            for (int i = 0; i < Classes.Length; i++)
            {
                int count = i + 1;
                Console.WriteLine("Class " + count + "of 7: ");
                Classes[i] = Console.ReadLine();
            }
            Lecturer lecturer = new Lecturer(Details[0], Details[1], Details[2], int.Parse(Details[3]), Qualification, Classes);
            lecturers.Add(lecturer);
            return lecturers;
        }
    }
}