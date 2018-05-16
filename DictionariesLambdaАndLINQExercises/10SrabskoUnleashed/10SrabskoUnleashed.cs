using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10SrabskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string singer = "";
            string venue = "";
            int ticketsPrice = 0;
            int ticketsCount = 0;
            long totalPrice = 0;

            var input = Console.ReadLine();
            var inputData = new List<string>();

            Dictionary<string, Dictionary<string, long>> venueSigersTotal = new Dictionary<string, Dictionary<string, long>>();

            while (input!="end")
            {
                //find singer
                int countAt = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (input.IndexOf("@")==i)
                    {
                        countAt++;
                    }
                }

                if (countAt>=2)
                {
                    input = Console.ReadLine();
                    continue;
                }
                int separator = input.IndexOf('@');

                singer = input.Substring(0, separator);
                if (singer.Length<=1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var singerNames = singer.Split(' ');
               

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < singerNames.Length; i++)
                {
                    if (i==singerNames.Length-1)
                    {
                        stringBuilder.Append(singerNames[i]);
                        break;
                    }
                    stringBuilder.Append(singerNames[i]).Append(" ");
                }

                singer = stringBuilder.ToString();

                string venueAndPrice = input.Substring(separator + 1);
                var venueAndPriceList = venueAndPrice.Split(' ').ToArray();


                for (int i = 0; i < venueAndPriceList.Length; i++)
                {
                    int result=0;
                    int tryPrice = int.TryParse(venueAndPriceList[i], out result);
                }

                totalPrice = ticketsPrice * ticketsCount;

                var singersAndprice= venueSigersTotal.Values;
                if (!venueSigersTotal.ContainsKey(venue))
                {
                    venueSigersTotal[venue] = new Dictionary<string, long>();
                    
                }
                if (!venueSigersTotal[venue].ContainsKey(singer))
                {
                    venueSigersTotal[venue][singer] = totalPrice;
                }
                else
                {
                    venueSigersTotal[venue][singer] += totalPrice;
                }
                input = Console.ReadLine();
            }

            foreach (var item in venueSigersTotal)
            {
                Console.WriteLine(item.Key);
                var singersAndPrice = item.Value;
                foreach (var singPricePair in singersAndPrice.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", singPricePair.Key,singPricePair.Value);
                }
            }

        }
    }
}
