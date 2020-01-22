using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                decimal coins = decimal.Parse(input);
                if (coins == 0.1m || coins == 0.2m || coins == 0.5m || coins == 1 || coins == 2 )
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "End")
                {
                    Console.WriteLine($"Change: {sum:F2}");
                    return;
                }
                if (product != "Nuts" && 
                    product != "Water" && 
                    product != "Crisps" && 
                    product != "Soda" && 
                    product != "Coke")
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                else if (product == "Nuts" && sum >= 2.0m)
                {
                    sum -= 2.0m;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (product == "Water" && sum >= 0.7m)
                {
                    sum -= 0.7m;
                    Console.WriteLine($"Purchased water");
                }
                else if (product == "Crisps" && sum >= 1.5m)
                {
                    sum -= 1.5m;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (product == "Soda" && sum >= 0.8m)
                {
                    sum -= 0.8m;
                    Console.WriteLine($"Purchased soda");
                }
                else if (product == "Coke" && sum >= 1.0m)
                {
                    sum -= 1.0m;
                    Console.WriteLine($"Purchased coke");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
        }
    }
}
