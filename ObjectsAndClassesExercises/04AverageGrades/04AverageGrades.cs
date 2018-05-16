using System;
using System.Linq;

namespace _04AverageGrades
{
    class Program
    {
        class Student
        {
            public string Name { set; get; }
            public   double[] Grades { set; get; }
            public double AverageGrade() {

                double average = Grades.Average();
                return average;
            }
                   

        }
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Dictinary<string, double> studentsAverage = new Dictinary<string, double>();

            for (int i = 0; i < numberOfLines; i++)
            {
                Student student = GetStudent();
                if (
                   )
                {

                }
            }
            
        }

        private static Student GetStudent()
        {
            string[] students = Console.ReadLine().Split().ToArray();
            double[] grades = students.Skip(1).Select(double.Parse).ToArray();

            Student student = new Student { Name = students[0], Grades = grades };

            return student;
        }
    }
}
