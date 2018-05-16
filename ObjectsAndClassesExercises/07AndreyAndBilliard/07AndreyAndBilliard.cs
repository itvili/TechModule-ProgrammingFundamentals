using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AndreyAndBilliard
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopingList { set; get; }
            public decimal Bill { get; set; }
        }

        static void Main()
        {
            int countOfProduct = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> menuItem = new Dictionary<string, decimal>();

            for (int i = 0; i < countOfProduct; i++)
            {
                string[] productsPrice = Console.ReadLine().Split('-').ToArray();
                string productName = productsPrice[0];
                decimal productPrice = decimal.Parse(productsPrice[1]);

                menuItem[productName] = productPrice;
            }

            var studentBuy = Console.ReadLine();

            List<Student> Students = new List<Student>();


            while (studentBuy != "end of clients")
            {

                var prodAndPrice = studentBuy.Split("-,".ToCharArray()).ToArray();
                Student currentStudent = new Student();
                currentStudent.ShopingList = new Dictionary<string, int>();
                string studentName = prodAndPrice[0];
                string studentProduct = prodAndPrice[1];
                int quantity = int.Parse(prodAndPrice[2]);
                if (menuItem.ContainsKey(studentProduct))
                {
                    currentStudent.Name = studentName;
                    int counter = 0;
                    foreach (var student in Students)
                    {
                        if (student.Name == studentName)
                        {
                            if (!student.ShopingList.ContainsKey(studentProduct))
                            {

                                student.ShopingList[studentProduct] = quantity;
                                student.Bill += quantity * menuItem[studentProduct];
                            }
                            else
                            {
                                student.ShopingList[studentProduct] += quantity;
                                student.Bill += (quantity * menuItem[studentProduct]);
                            }

                            counter++;
                        }

                    }

                    if (counter == 0)
                    {
                        if (!currentStudent.ShopingList.ContainsKey(studentProduct))
                        {

                            currentStudent.ShopingList[studentProduct] = quantity;
                            currentStudent.Bill = quantity * menuItem[studentProduct];
                        }

                        Students.Add(currentStudent);
                    }

                    counter = 0;

                }

                studentBuy = Console.ReadLine();
            }

            foreach (var item in Students.OrderBy(x => x.Name).ThenBy(x => x.Bill))
            {
                Console.WriteLine("{0}", item.Name);
                var shopingList = item.ShopingList;
                foreach (var shplist in shopingList)
                {

                    Console.WriteLine("-- {0} - {1}", shplist.Key, shplist.Value);
                }
                Console.WriteLine("Bill: {0:f2}", item.Bill);

            }
            var totalBill = Students.Sum(x => x.Bill);
            Console.WriteLine("Total bill: {0:f2}", totalBill);
        }
    }
}
