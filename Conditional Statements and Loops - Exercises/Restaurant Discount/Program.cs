using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName="";
            double priceHall = 0.0; ;

            if (groupSize<=50)
            {
                hallName = "Small Hall";
                priceHall = 2500;
            }
            else if (groupSize>50&&groupSize<=100)
            {
                hallName = "Terrace";
                priceHall = 5000;
            }
            else if(groupSize>100&&groupSize<=120)
            {
                hallName = "Great Hall";
                priceHall = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            double pricePackage=0.0;
            double totalPrice=0.0;
            switch (package)
            {
                case "Normal":
                    pricePackage = 500;
                    totalPrice = (priceHall + pricePackage) * 0.95;
                    break;
                case "Gold":
                    pricePackage = 750;
                    totalPrice = (priceHall + pricePackage) * 0.90;
                    break;
                case "Platinum":
                    pricePackage = 1000;
                    totalPrice = (priceHall + pricePackage) * 0.85;
                    break;
                
            }
            double pricePerPerson = totalPrice / groupSize;
            if (!(groupSize>=121))
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }



            

        }
    }
}
