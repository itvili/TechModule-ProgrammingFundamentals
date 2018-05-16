using System;
using System.Collections.Generic;
using System.Linq;

namespace _07SalesReport
{
    class Program
    {
        class Sale
        {
            public string Town { set; get; }
            public string Product { set; get; }
            public decimal Price { set; get; }
            public decimal Quantity { set; get; }
        }
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> townsAndSales = new Dictionary<string, decimal>();

            for (int i = 0; i < lines; i++)
            {
               Sale sales = GetSale();
                decimal total = sales.Price * sales.Quantity;

                if (!townsAndSales.ContainsKey(sales.Town))
                {
                    townsAndSales[sales.Town] = total;
                }
                else
                {
                    townsAndSales[sales.Town] += total;
                }
            }

            foreach (var item in townsAndSales.OrderBy(x=>x.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value);
            }
           
        }

        private static Sale GetSale()
        {
            string[] inputData = Console.ReadLine().Split().ToArray();
            Sale sales = new Sale()
            { Town = inputData[0], Product = inputData[1], Price = decimal.Parse(inputData[2]), Quantity = decimal.Parse(inputData[3]) };
            return sales;
        }
    }
}
