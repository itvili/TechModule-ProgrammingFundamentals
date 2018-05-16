using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10StudentGroups
{
    class Program
    {
        class Student
        {
            public string Email { get; set; }
            public string Name { get; set; }
            public DateTime RegistrationDate { get; set; }
        }
        class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students {get;set;}
        }
        class Group
        {
            public Town Town { get; set; }
            public List<Student> Student { get; set; }
        }
        static void Main()
        {
            var input = Console.ReadLine();
            List<Town> townsTotal = new List<Town>();
            if (input.Contains("=>"))
            {
                var townInput = input.Split(new[] { ' ', '=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Town town = new Town();
                town.Students = new List<Student>();
                town.Name = townInput[0];
                town.SeatsCount = int.Parse(townInput[1]);

                townsTotal.Add(town);

            }
            else
            {
                var studentsInput = input.Split(new[] { '|',' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Student student = new Student();
                student.Name = studentsInput[0]+" "+studentsInput[1];
                student.Email = studentsInput[2];
                student.RegistrationDate = DateTime.ParseExact(studentsInput[3], "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                
            }
        }
    }
}
