using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            playGame();
        }

        private static void playGame()
        {
            Console.Clear();
            string[] answers = {"I would say, that by my calculations, there is a theoretical probablity of 52%",
                                "Of course!",
                                "Nope nope nope nope nope",
                                "God knows, but he won't say",
                                "yeet-o-tron crashed, please try again",
                                "I am not powerful enough to answer that",
                                "access denied",
                                "It's as certain as the existence of humanity. Wait...",
                                "I'm afraid I cannot answer that, Dave",
                                "Don't let the slightest sliver of doubt enter your mind"};

            string[] thinking = {"thinking about it",
                                 "summoning mysterious powers beyond your understanding",
                                 "asking a friend"};

            Console.WriteLine("Welcome! Ask me a question that can be answered by either 'Yes' or 'No'.");
            Console.WriteLine("Type 'exit' to leave me.");
            Console.WriteLine("------------------------");
            string choice = Console.ReadLine();
            Random rnd = new Random();
            Console.Clear();
            Console.WriteLine($"...{thinking[rnd.Next(3)]}...");
            Thread.Sleep(2300);
            Console.Clear();
            Console.WriteLine(answers[rnd.Next(9)]);
            Console.WriteLine();
            Console.WriteLine("...press any key to continue...");
            Console.ReadKey();
            
            if (choice != "exit")
            {
                playGame();
            }
        }
    }
}
