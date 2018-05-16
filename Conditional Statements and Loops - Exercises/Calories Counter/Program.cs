using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ingredient = "";
            int countCheese = 0;
            int countTomatoSauce = 0;
            int countSalami = 0;
            int countPepper = 0;


            for (int i = 0; i < n; i++)
            {
                ingredient = Console.ReadLine().ToLower();

                if (ingredient=="cheese")
                {
                    countCheese++;
                }
                else if (ingredient=="tomato sauce")
                {
                    countTomatoSauce++;
                }
                else if (ingredient=="salami")
                {
                    countSalami++;
                }
                else if (ingredient=="pepper")
                {
                    countPepper++;
                }
            }
            int calories = countCheese * 500 + countTomatoSauce * 150 + countSalami * 600 + countPepper * 50;
            Console.WriteLine("Total calories: {0}", calories);


        }
    }
}
