using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            sbyte num1 = 0;
            byte num2 = 0;
            short num3 = 0;
            ushort num4 = 0;
            int num5 = 0;
            uint num6 = 0;
            long num7 = 0L;
            

            if (sbyte.TryParse(number, out num1)|| byte.TryParse(number, out num2)|| short.TryParse(number, out num3)|| ushort.TryParse(number, out num4)||
               int.TryParse(number, out num5)|| uint.TryParse(number, out num6)|| long.TryParse(number, out num7))
            {

                Console.WriteLine("{0} can fit in:", number);
                if (sbyte.TryParse(number, out num1))
                {
                    Console.WriteLine("* sbyte");
                }
                if (byte.TryParse(number, out num2))
                {
                    Console.WriteLine("* byte");
                }
                if (short.TryParse(number, out num3))
                {
                    Console.WriteLine("* short");
                }
                if (ushort.TryParse(number, out num4))
                {
                    Console.WriteLine("* ushort");
                }
                if (int.TryParse(number, out num5))
                {
                    Console.WriteLine("* int");
                }
                if (uint.TryParse(number, out num6))
                {
                    Console.WriteLine("* uint");
                }
                if (long.TryParse(number, out num7))
                {
                    Console.WriteLine("* long");
                }

            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", number);
            }
            
        }
    }
}
