using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            string revurse = "";
            for (int i = inputName.Length - 1; i >= 0; i--)
            {
                revurse += inputName[i];
            }
            for (int j = 1; j <= 4; j++)
            {
                string input = Console.ReadLine();
                if (input == revurse)
                {
                    Console.WriteLine("User " + inputName + " logged in.");
                    return;
                }
                if (j == 4 && input != revurse)
                {
                    Console.WriteLine("User " + inputName + " blocked!");
                    return;
                }
                else if (input != revurse)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
