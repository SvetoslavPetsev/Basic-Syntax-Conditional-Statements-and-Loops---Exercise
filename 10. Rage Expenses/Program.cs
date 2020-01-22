using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            bool trashHeadset = false;
            bool trashMouse = false;
            int headsetGarbage = 0;
            int mouseGarbage = 0;
            int keyboardGarbage = 0;
            int displayGarbage = 0;

            int keyboardToDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetGarbage++;
                    trashHeadset = true;
                }
                if (i % 3 == 0)
                {
                    mouseGarbage++;
                    trashMouse = true;
                }
                if (trashMouse == true && trashHeadset == true)
                {
                    keyboardGarbage++;
                    keyboardToDisplay++;
                    if (keyboardToDisplay % 2 == 0)
                    {
                        displayGarbage++;
                    }
                }
                trashHeadset = false;
                trashMouse = false;
            }
            decimal totalExp = headsetGarbage * headsetPrice + mouseGarbage * mousePrice + keyboardGarbage * keyboardPrice + displayGarbage * displayPrice;
            Console.WriteLine($"Rage expenses: {totalExp:F2} lv.");
        }
    }
}
