using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = uint.Parse(Console.ReadLine());
            short hours = short.Parse(Console.ReadLine());
            short minutes = short.Parse(Console.ReadLine());
            short seconds = short.Parse(Console.ReadLine());

            int totalSeconds = hours * 3600 + minutes * 60 + seconds;

            float speedMetersPerSeconds=distanceInMeters/totalSeconds;
            float speedKilometersPerHour = speedMetersPerSeconds * 18 / 5;
            float speedMilesPerHour = speedKilometersPerHour/ 1.609f;

            Console.WriteLine("{0:0.#######}",speedMetersPerSeconds);
            Console.WriteLine("{0:0.#######}",speedKilometersPerHour);
            Console.WriteLine("{0:0.#######}", speedMilesPerHour);
        }
    }
}
