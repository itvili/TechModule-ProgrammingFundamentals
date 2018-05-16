using System;
using System.Collections.Generic;
using System.Linq;

namespace _04AverageGrade1
{
    class Program
    {
        class Student
        {
            public string Name { set; get; }
            public double[] Grades { set; get; }
            public double AverageGrade
            {
                get
               { double average = Grades.Average();
                    return average; }
            }
                    }
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Student> studentsAndGrades = new List<Student>();

            for (int i = 0; i < numberOfLines; i++)
            {
                Student student = GetStudent();
                
                studentsAndGrades.Add(student);
            }

            var orederedStudentBygrades = studentsAndGrades
               .Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x=>x.AverageGrade).ToArray();


            foreach (var item in orederedStudentBygrades)
            {
                Console.WriteLine("{0} -> {1:f2}", item.Name, item.AverageGrade);
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
