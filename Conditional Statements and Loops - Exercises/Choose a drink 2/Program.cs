using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_drink_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string drink;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }
            double price;
            switch (drink)
            {
                case "Water":
                    price = 0.70;
                    break;
                case "Coffee":
                    price = 1.00;
                    break;
                case "Beer":
                    price = 1.70;
                    break;
                default:
                    price = 1.20;
                    break;
               
            }
            double totalPrice = quantity * price;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
