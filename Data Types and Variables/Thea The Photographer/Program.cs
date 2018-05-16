using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactorPercent = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long totalFilterTime = numberOfPictures * filterTime;
            double totalPhotos =Math.Ceiling((double)numberOfPictures * filterFactorPercent / 100);
            long totalUploadTime = (long)totalPhotos * uploadTime;

            long totalTime = totalFilterTime + totalUploadTime;

            TimeSpan timeSpan = TimeSpan.FromSeconds(totalTime);
            string time = String.Format("{0}:{1:d2}:{2:d2}:{3:d2}", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);

            Console.WriteLine(time);
            
        }
    }
}
