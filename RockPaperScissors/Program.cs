using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userScore = 0;
            int computerScore = 0;
            bool repeat = true;

            while (repeat == true)
            {
                string result = "draw";
                PrintScore(ref userScore, ref computerScore);
                string userChoice = UserTurn();
                string computerChoice = ComputerTurn();
                result = DetermineWinner(userChoice, computerChoice);
                GiveFeedback(result, userChoice, computerChoice);
                UpdateScores(result, ref userScore, ref computerScore);
                repeat = PlayAgain();
            }
        }

        private static bool PlayAgain()
        {
            string choice = "";
            while (choice != "y" && choice != "n")
            {
                Console.Write("Play again? y/n: ");
                choice = Console.ReadLine();
            }
            if (choice == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void UpdateScores(string result, ref int userScore, ref int computerScore)
        {
            if (result == "Win")
            {
                userScore++;
            }
            else if (result == "Lose")
            {
                computerScore++;
            }
        }

        private static void GiveFeedback(string result, string userChoice, string computerChoice)
        {
            Console.WriteLine($"{result}! The computer chose {computerChoice} and you chose {userChoice}");
        }

        private static string DetermineWinner(string user, string computer)
        {
            if (user == "Rock")
            {
                if (computer == "Rock")
                {
                    return "Draw";
                }
                else if (computer == "Paper")
                {
                    return "Lose";
                }
                else
                {
                    return "Win";
                }
            }

            else if (user == "Paper")
            {
                if (computer == "Rock")
                {
                    return "Win";
                }
                else if (computer == "Paper")
                {
                    return "Draw";
                }
                else
                {
                    return "Lose";
                }
            }

            else
            {
                if (computer == "Rock")
                {
                    return "Lose";
                }
                else if (computer == "Paper")
                {
                    return "Win";
                }
                else
                {
                    return "Draw";
                }
            }
        }

        private static string ComputerTurn()
        {
            Random rnd = new Random();
            int choice = rnd.Next(3);

            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }
        private static string UserTurn()
        {
            string choice = "";
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("1: Rock");
                Console.WriteLine("2: Paper");
                Console.WriteLine("3: Scissors");
                Console.Write("Your Choice: ");
                choice = Console.ReadLine();
            }

            if (choice == "1")
            {
                return "Rock";
            }
            else if (choice == "2")
            {
                return "Paper";
            }
            else if (choice == "3")
            {
                return "Scissors";
            }
            else
            {
                return "Please choose from above numbers";
            }
        }

        private static void PrintScore(ref int userScore, ref int computerScore)
        {
            Console.Clear();
            Console.WriteLine($"User: {userScore}\nComputer: {computerScore}");
            Console.WriteLine("--------------");
        }
    }
}
