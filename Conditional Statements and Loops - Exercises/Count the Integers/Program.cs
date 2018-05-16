using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countInteger = 0;
            try
            {
                while (true)
                {
                    var input = Console.ReadLine();
                    int integer = int.Parse(input);
                    countInteger++;
                }
            }
            catch (Exception)
            {

                Console.WriteLine(countInteger);
            }
        }
    }
}
