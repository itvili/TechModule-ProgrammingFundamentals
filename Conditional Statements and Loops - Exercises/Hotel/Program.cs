using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuit = 0.0;

            
            if (month=="May"||month=="October")
            {
                
                priceStudio = 50.0;
                priceDouble = 65.0;
                priceSuit = 75.0;
                if (days > 7)
                {
                    priceStudio *= 0.95;
                }
            }
            else if (month=="June"||month=="September")
            {
                priceStudio = 60.0;
                priceDouble = 72.0;
                priceSuit = 82.0;
                if (days > 14)
                {
                    priceDouble *= 0.90;
                }
            }
            else
            {
                priceStudio = 68.0;
                priceDouble = 77.0;
                priceSuit = 89.0;
                if (days>14)
                {
                    priceSuit *= 0.85;
                }
            }
            double priceStudioPerStay = priceStudio*days;
            double priceDoublePerStay = priceDouble*days;
            double priceSuitPerStay = priceSuit*days;

            if (days > 7 && (month == "September" || month == "October"))
            {
                priceStudioPerStay -= priceStudio;
            }

            Console.WriteLine("Studio: {0:f2} lv.", priceStudioPerStay);
            Console.WriteLine("Double: {0:f2} lv.", priceDoublePerStay);
            Console.WriteLine("Suite: {0:f2} lv.", priceSuitPerStay);



        }

    }
}
