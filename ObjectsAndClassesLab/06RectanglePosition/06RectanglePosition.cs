using System;
using System.Linq;

namespace _06RectanglePosition
{
    class Program
    {
        class Rectangle
        {
            public  int TopX { set; get; }
            public  int LeftY { set; get; }
            public  int Widht { set; get; }
            public  int Height { set; get; }

            public int Right() {

                int right = TopX+Height;
                return right;
            }

            public int Bottom()
            {

                int bottom =LeftY + Widht;
                return bottom;
            }


        }
        static void Main(string[] args)
        {
            Rectangle rec1, rec2;
            GetRectangle(out rec1, out rec2);

            if (IsInside(rec1, rec2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        private static void GetRectangle(out Rectangle rec1, out Rectangle rec2)
        {
            int[] firstRectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondRectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();


            rec1 = new Rectangle()
            { LeftY = firstRectangle[0], TopX = firstRectangle[1], Widht = firstRectangle[2], Height = firstRectangle[3] };
            rec2 = new Rectangle()
            { LeftY = secondRectangle[0], TopX = secondRectangle[1], Widht = secondRectangle[2], Height = secondRectangle[3] };
        }

        static bool IsInside(Rectangle rec1,Rectangle rec2)
        {
            bool isInside = rec1.LeftY >= rec2.LeftY && rec1.Right() <= rec2.Right()
                && rec1.TopX <= rec1.TopX && rec1.Bottom() <= rec2.Bottom();
            return isInside;
        }

              
    }
}
