using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            bool div2 = false;
            bool div3 = false;
            bool div6 = false;
            bool div7 = false;
            bool div10 = false;

            if (inputNumber % 2 == 0)
            {
                div2 = true;
            }
            if (inputNumber % 3 == 0)
            {
                div3 = true;
            }
            if (inputNumber % 6 == 0)
            {
                div6 = true;
            }
            if (inputNumber % 7 == 0)
            {
                div7 = true;
            }
            if (inputNumber % 10 == 0)
            {
                div10 = true;
            }
            if (div10 == true)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (div7 == true)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (div6 == true)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (div3 == true)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (div2 == true)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
