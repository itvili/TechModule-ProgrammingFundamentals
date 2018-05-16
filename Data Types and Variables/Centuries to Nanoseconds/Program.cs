using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centures = byte.Parse(Console.ReadLine());

            int years = centures * 100;
            double days = Math.Floor(years * 365.2422);
            double hours = Math.Floor(days * 24);
            double minutes = Math.Floor(hours * 60);
            decimal seconds = Math.Floor((decimal)minutes * 60);
            decimal miliseconds = Math.Floor(seconds * 1000);
            decimal microseconds = Math.Floor(miliseconds * 1000);
            decimal nanoseconds = Math.Floor(microseconds * 1000);

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes = {seconds} seconds = " +
                $"{miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");



        }
    }
}
