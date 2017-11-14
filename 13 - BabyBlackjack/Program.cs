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
            Console.WriteLine("---------------------------------------------");
            int playerTotal = DealCards(rnd, "You");
            int dealerTotal = DealCards(rnd, "The dealer");
            Console.WriteLine("---------------------------------------------");
            bool playerWins = determineWinner(playerTotal, dealerTotal);
            PayOut(playerWins, betAmount, ref bal);
            Menu(ref bal);
        }

        private static void Menu(ref float bal)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Dealer: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Would you like another game? y/n: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            Console.ForegroundColor = ConsoleColor.White;
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Dealer: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You got me this time...");
                return true;
            }
            else if (dealer > player)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Dealer: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hah! You can't defeat me!");
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Dealer: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("We draw. I win");
                return false;
            }
        }

        private static int DealCards(Random rnd, string player)
        {
            int card1 = rnd.Next(11);
            int card2 = rnd.Next(11);
            int total = card1 + card2;
            Console.Write($"{player} drew ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(card1);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" and ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(card2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" for a total of ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(total);
            Console.ForegroundColor = ConsoleColor.White;

            return total;
        }

        private static float MakeBet(ref float bal)
        {
            float betAmount = 0;
            bool validBet = false;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Dealer: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"How much you wanna bet? You're sitting on ${bal}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("$");

            while (validBet != true)
            {
                validBet = float.TryParse(Console.ReadLine(), out betAmount);

                if (betAmount > bal)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Dealer: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Sorry, but your a** is too broke for that. Go a bit lower.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("You: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("$");
                    validBet = false;
                }
                else if (betAmount < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Dealer: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Get outta here with your fancy negatives! Proper bet please.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("You: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("$");
                    validBet = false;
                }
                else if (betAmount == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Dealer: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You need to bet SOMETHING, y'know...");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("You: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("$");
                    validBet = false;
                }
            }

            bal = bal - betAmount;
            return betAmount;
        }
    }
}
