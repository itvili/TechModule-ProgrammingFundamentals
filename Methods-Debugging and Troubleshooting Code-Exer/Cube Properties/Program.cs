using System;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Console.WriteLine("{0:f2}", CalculateParameter(sideCube, parameter));
        }

        static double CalculateParameter(double side, string parameter)
        {
            double calculatedParameter = 0.0;
            
            switch (parameter)
            {
                case "face":
                    return calculatedParameter = Math.Sqrt(Math.Pow(side, 2)*2);

                case "space":
                    return calculatedParameter = Math.Sqrt(Math.Pow(side, 2) * 3);
                case "volume":
                    return calculatedParameter = Math.Pow(side, 3);
                default:
                    return calculatedParameter = 6*Math.Pow(side,2);
            }
        }
    }
}
