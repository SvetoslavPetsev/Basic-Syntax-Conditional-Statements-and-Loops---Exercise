using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            decimal lightPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal belttPrice = decimal.Parse(Console.ReadLine());

            decimal totalPriceLight = Math.Ceiling(studentsNumber* 1.1m) * lightPrice ;
            decimal totalPriceRobe = robePrice * studentsNumber;
            decimal totalPriceBelt = 0;
            for (int i = 1; i <= studentsNumber; i++)
            {
                decimal oldprice = belttPrice;
                if (i % 6 == 0)
                {
                    belttPrice = 0;
                }
                totalPriceBelt += belttPrice;
                belttPrice = oldprice;
            }
            decimal finalSum = totalPriceLight + totalPriceRobe + totalPriceBelt;
            if (finalSum <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {finalSum:F2}lv.");
            }
            else
            {
                decimal diff = finalSum - money;
                Console.WriteLine($"Ivan Cho will need {diff:F2}lv more.");
            }
        }
    }
}
