using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> playerTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (playerOne.Count != 0 && playerTwo.Count != 0)
            {
                int cardOne = playerOne[0];
                int cardTwo = playerTwo[0];

                if (playerOne[0] > playerTwo[0])
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);

                    playerOne.Add(cardOne);
                    playerOne.Add(cardTwo);
                }
                else if (playerOne[0] < playerTwo[0])
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);

                    playerTwo.Add(cardTwo);
                    playerTwo.Add(cardOne);
                }
                else if (playerOne[0] == playerTwo[0])
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
            }
            if (playerTwo.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
        }
    }
}
