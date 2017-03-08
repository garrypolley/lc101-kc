using System;
using System.Collections.Generic;

namespace school_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var course = new Course();

            foreach (string name in GetNames()) {
                double gpa = Student.GenerateGpa();

                var newStudent = new Student();
                newStudent.Name = name;
                newStudent.Gpa = gpa;
                newStudent.NumberOfCredits = 15;

                students.Add(newStudent);
            }

            foreach (Student student in students) {
                Console.WriteLine(string.Format("Hello {0}!", student));
                course.AddStudent(student);
            }

            course.Name = "Cool Class";

            Console.WriteLine();
            Console.WriteLine("Our Course -- \n {0}", course);
        }

        static List<string> GetNames() {
            var rnd = new Random();
            var nameChoices = new List<string>(){
                "Garry",
                "Carl",
                "Suzy",
                "Carol",
                "Jill",
                "Sandy",
                "Bobby",
                "Jacqueline",
                "A-A-Ron",
                "BaLockAy"
            };

            var chosenNames = new List<string>();
            for (int i = 0; i < 20; i++) {
                int choiceIndex = rnd.Next(0, nameChoices.Count);
                chosenNames.Add(nameChoices[choiceIndex]);
            }

            return chosenNames;
        }
    }
}
