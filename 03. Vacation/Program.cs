using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double discountconst = 1;

            switch (groupType)
            {
                case "Students":
                    if (peopleNumber >= 30)
                    {
                        discountconst = 0.85;
                    }
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    if (peopleNumber >= 100)
                    {
                        peopleNumber -= 10;
                    }
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    if (peopleNumber >= 10 && peopleNumber <= 20)
                    {
                        discountconst = 0.95;
                    }
                    switch (day)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            double totalPrice = peopleNumber * price * discountconst;
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
