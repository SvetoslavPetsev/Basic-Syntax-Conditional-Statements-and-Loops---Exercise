using System;

namespace _03._Vacation_var2
{
    class Program
    {
        static void Main()
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            decimal price = 0;
            decimal discount = 0m;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45m;
                }
                else if (day == "Saturday")
                {
                    price = 9.80m;
                }
                else 
                {
                    price = 10.46m;
                }
                if (peopleNumber >= 30)
                {
                    discount = price * peopleNumber * 0.15m;
                }
            }
            else if (groupType == "Business")
            {

                if (day == "Friday")
                {
                    price = 10.90m;
                }
                else if (day == "Saturday")
                {
                    price = 15.60m;
                }
                else 
                {
                    price = 16.00m;
                }
                if (peopleNumber >= 100)
                {
                    peopleNumber -= 10;
                }
            }
            else if(groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15.00m;
                }
                else if (day == "Saturday")
                {
                    price = 20.00m;
                }
                else 
                {
                    price = 22.50m;
                }
                if (peopleNumber >= 10 && peopleNumber <= 20)
                {
                    discount = price * peopleNumber * 0.05m;
                }
            }
            decimal totalPrice = (price * peopleNumber) - discount;
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
