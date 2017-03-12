using System;
using System.Collections.Generic;

namespace student_example
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++) {
                var student = CreateStudent();

                // See docs for formatting: https://msdn.microsoft.com/en-us/library/dn961160.aspx
                Console.WriteLine($"{student}\nGPA: {student.Gpa}\n\n");
            }
        }

        private static Student CreateStudent() {

            var student = new Student(RandomName());
            Console.WriteLine(student);


            for(var i = 0; i  < Rand.Next(4, 15); i++) {
                student.AddGrade(RandomCredit(), RandomGrade());
            }

            return student;
        }

        private static string RandomName() {
            var strings = new List<string>() {
                "Cory",
                "Cheryl",
                "George",
                "Jimmy",
                "Sara",
                "Laura",
                "Theda",
            };

            return strings[Rand.Next(0, strings.Count-1)];
        }

        private static Random Rand = new Random();

        private static int RandomCredit() {
            return Rand.Next(3, 10);
        }

        private static double RandomGrade() {
            return Rand.Next(0, 400) / 100;
        }
    }
}
