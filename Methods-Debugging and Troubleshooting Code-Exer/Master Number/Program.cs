using System;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int number = 0; number <= endNumber; number++)
            {
                string strNumber = Convert.ToString(number);
                if (IsPalindrome(strNumber)&&IsDivisibleBy7(number)&&IsEvenDigit(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool IsPalindrome(string strNumber)
        {
            
            if (strNumber.Length==1||strNumber.Length==0)
            {
                return true;
            }
            return strNumber[0] ==strNumber[strNumber.Length - 1] && IsPalindrome(strNumber.Substring(1, strNumber.Length - 2));
        }

        static bool IsDivisibleBy7(int number)
        {
            int sum = 0;
            while (number>0)
            {
                int num = number % 10;
                number = number / 10;
                sum =sum+ num;
            }
            if (sum%7==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsEvenDigit(int number)
        {
           
            while (number > 0)
            {
                int num = number % 10;
                number = number / 10;
                if (num%2==0)
                {
                    return true;
                    
                }

                
            }
            return false;
            
        }
    }
}
