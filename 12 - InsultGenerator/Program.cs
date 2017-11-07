using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___InsultGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetName();
            Random rnd = new Random();
            GenerateInsult(name, rnd);
        }

        private static string GetName()
        {
            Console.WriteLine("Welcome to the insult-o-tron. What do they call you?");
            return Console.ReadLine();
        }

        private static void GenerateInsult(string name, Random rnd)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(name + ", you are " + GetAdjective(rnd)+ " " + GetCompundAdjective(rnd) + " " + GetObject(rnd));
            Menu(name, rnd);
        }

        private static void Menu(string name, Random rnd)
        {
            Console.Write("Again? y/n: ");
            if (Console.ReadLine() == "y")
            {
                GenerateInsult(name, rnd);
            }
            else if (Console.ReadLine() == "n")
            {

            }
        }

        private static string GetAdjective(Random rnd)
        {
            string[] adjectives = {"an uneducated", "a piece of", "an amazingly", "a really", "a great", "an entirely", "an extraordinarily", "a special kind of", "a Cooper-like"};
            return adjectives[rnd.Next(9)];
        }

        private static string GetCompundAdjective(Random rnd)
        {
            string[] compoundAdjectives = {"beautiful", "daft", "dumb", "kind", "supportive", "bald", "middle-aged", "non-functioning", "cooper-ish"};
            return compoundAdjectives[rnd.Next(9)];
        }

        private static string GetObject(Random rnd)
        {
            string[] objects = {"man", "woman", "human being", "poo poo face", "Cooper", "person"};
            return objects[rnd.Next(6)];
        }
    }
}
