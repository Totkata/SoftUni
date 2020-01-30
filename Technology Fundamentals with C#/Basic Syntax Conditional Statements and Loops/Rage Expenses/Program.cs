using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double gameExpenses = 0;

            for (int game = 1; game <= lostGameCount; game++)
            {
                if (game % 12 == 0)
                {
                    gameExpenses += headsetPrice + keyboardPrice + mousePrice + displayPrice;
                }
                else if (game % 6 == 0)
                {
                    gameExpenses += headsetPrice + keyboardPrice + mousePrice;
                }
                else if (game % 3 == 0)
                {
                    gameExpenses += mousePrice;
                }
                else if (game % 2 == 0)
                {
                    gameExpenses += headsetPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {gameExpenses:f2} lv.");
        }
    }
}
