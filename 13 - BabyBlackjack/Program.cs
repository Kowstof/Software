using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___BabyBlackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            float bal = 10;
            playGame(ref bal);
        }

        private static void playGame(ref float bal)
        {
            Console.Clear();
            float betAmount = MakeBet(ref bal);
            Random rnd = new Random();
            int playerTotal = DealCards(rnd, "You");
            int dealerTotal = DealCards(rnd, "The dealer");
            bool playerWins = determineWinner(playerTotal, dealerTotal);
            PayOut(playerWins, betAmount, ref bal);
            Menu(ref bal);
        }

        private static void Menu(ref float bal)
        {
            Console.Write("Would you like another game? y/n: ");
            if (Console.ReadLine() == "y")
            {
                playGame(ref bal);
            }
        }

        private static void PayOut(bool playerWins, float betAmount, ref float bal)
        {
            if (playerWins)
            {
                bal = bal + (betAmount * 2);
            }
        }

        private static bool determineWinner(int player, int dealer)
        {
            if (player > dealer)
            {
                Console.WriteLine("You got me this time...");
                return true;
            }
            else if (dealer > player)
            {
                Console.WriteLine("Hah! You can't defeat me!");
                return false;
            }
            else
            {
                Console.WriteLine("We draw. I win");
                return false;
            }
        }

        private static int DealCards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card2;
            Console.WriteLine($"{player} drew {card1} and {card2} for a total of {total}");
            return total;
        }

        private static float MakeBet(ref float bal)
        {
            float betAmount = 0;
            bool validBet = false;

            Console.WriteLine($"Enter your bet. You have ${bal}");

            while (validBet != true)
            {
                validBet = float.TryParse(Console.ReadLine(), out betAmount);

                if (betAmount > bal)
                {
                    Console.WriteLine("Sorry, but your a** is too broke for that. Go a bit lower.");
                    validBet = false;
                }
                else if (betAmount < 0)
                {
                    Console.WriteLine("Get outta here with your fancy negatives! Proper bet please.");
                    validBet = false;
                }
            }

            bal = bal - betAmount;
            return betAmount;
        }
    }
}
