using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            if (n >= 1 && n <= 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    counter = i;
                    while (counter > 0)
                    {
                        Console.Write(i);
                        Console.Write(" ");
                        counter--;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
