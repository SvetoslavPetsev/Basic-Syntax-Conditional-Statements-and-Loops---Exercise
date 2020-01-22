using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numberI = int.Parse(number);
            int fact;
            int sum = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                char one = number[i];
                int oneI = (int)Char.GetNumericValue(one);
                fact = 1;
                for (int j = 1; j <= oneI; j++)
                {
                    fact *= j;
                }
                sum += fact;
            }
            if (numberI == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
