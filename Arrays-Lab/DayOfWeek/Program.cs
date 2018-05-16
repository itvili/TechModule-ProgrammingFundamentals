using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if (day>=1&&day<=7)
            {
                string result = days[day-1];
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
