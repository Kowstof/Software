using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int guess = -1;
            int count = 0;

            Console.WriteLine("==============================");
            Console.WriteLine("Welcome to the Rand-o-guesser!");
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.Write("Please enter minimum number: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please enter maximum number: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            Console.WriteLine("Guess to start!");
            Console.WriteLine();
            int number = rnd.Next(min, max);


            while (guess != number)
            {
                count++;
                guess = int.Parse(Console.ReadLine());
    
                if (guess > number)
                {
                    Console.WriteLine("Try lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Try higher");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("                                   .''.");
                    Console.WriteLine("       .''.      .        *''*    :_\\/_:     . ");
                    Console.WriteLine("      :_\\/_:   _\\(/_  .:.*_\\/_*   : /\\ :  .'.:.'.");
                    Console.WriteLine("  .''.: /\\ :   ./)\\   ':'* /\\ * :  '..'.  -=:o:=-");
                    Console.WriteLine(" :_\\/_:'.:::.    ' *''*    * '.\'/.' _\\(/_'.':'.'");
                    Console.WriteLine(" : /\\ : :::::     *_\\/_*     -= o =-  /)\\    '  *");
                    Console.WriteLine("  '..'  ':::'     * /\\ *     .'/.\'.   '");
                    Console.WriteLine("                   *..*         :");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine($"                 It is {number} indeed!");
                    Console.WriteLine($"                    Tries: {count}");
                    Console.ReadKey();
                }
            }
        }
    }
}
