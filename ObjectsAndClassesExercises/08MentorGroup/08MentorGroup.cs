using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08MentorGroup
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<DateTime> Dates { get; set; }
            public List<string> Comments { get; set; }

        }
        static void Main()
        {
            var input= Console.ReadLine();
            Dictionary<string, Student> studentsActivity = new Dictionary<string, Student>();
            while (input!="end of dates")
            {
                var studentsDates = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string studentName = studentsDates[0];
                List<DateTime> dates = new List<DateTime>();
                for (int i = 1; i < studentsDates.Count; i++)
                {
                    var currentDate = DateTime.ParseExact(studentsDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dates.Add(currentDate);
                }
                Student student = new Student();
                student.Name = studentName;
                student.Dates = new List<DateTime>();
                
                student.Dates.AddRange(dates);
                if (!studentsActivity.ContainsKey(studentName))
                {
                    studentsActivity.Add(studentName, student);
                    studentsActivity[studentName].Comments = new List<string>();
                }
                else
                {
                    studentsActivity[studentName].Dates.AddRange(dates);  
                }

                input = Console.ReadLine();
                dates.Clear();
            }

            var inputComments = Console.ReadLine();
            List<string> commentsAboutStudent = new List<string>();
            while (inputComments != "end of comments")
            {
               var comments= inputComments.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string studentName = comments[0];
                //for (int i = 1; i < comments.Length; i++)
                //{
                    string studentComments = comments[1];
                    //commentsAboutStudent.Add(studentComments);
                //}
                if (studentsActivity.ContainsKey(studentName))
                {
                    
                    studentsActivity[studentName].Comments.Add(studentComments);
                }
                inputComments = Console.ReadLine();
                //commentsAboutStudent.Clear();
            }

            foreach (var student in studentsActivity.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}", student.Key);

                Console.WriteLine("Comments:");
                foreach (var comm in student.Value.Comments)
                {
                    Console.WriteLine("- {0}", comm);
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Value.Dates.OrderBy(x => x))
                {
                    Console.WriteLine("-- {0:dd/MM/yyyy}", date);
                }
            }
        }
    }
}
