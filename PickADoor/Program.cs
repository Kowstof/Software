using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a door:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ShowDoor();
                Console.WriteLine("Behind door 1 is the kitchen");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                ShowDoor();
                Console.WriteLine("Behind door 2 is the entrance to the dungeon");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                ShowDoor();
                Console.WriteLine("Behind door 3 is a kid insulting your mum on Call of Duty");
                Console.ReadKey();
            }
            else
            {
                ShowDoor();
                Console.WriteLine($"You concentrated so hard to choose a door that doesn't exist, that you created a portal to another dimension with your mind, and teleported yourself there, so that you could choose door {choice}. This also disprove all of our known laws of physics, therefore breaking our universe.");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("                             ____");
                Console.WriteLine("                     __,-~~/~    `---.");
                Console.WriteLine("                   _/_,---(      ,    )");
                Console.WriteLine(@"               __ /        <    /   )  \___");
                Console.WriteLine("- ------===;;;'====------------------===;;;===----- -  -");
                Console.WriteLine("                  \\/  ~\"~\"~\"~\"~\"~\\~\"~)~\" / ");
                Console.WriteLine("                  (_ (   \\  (     >    \\)");
                Console.WriteLine("                   \\_( _ <         >_>'");
                Console.WriteLine("                      ~ `-i' ::>|--\"");
                Console.WriteLine("                          I;|.|.|");
                Console.WriteLine("                         <|i::|i|`.");
                Console.WriteLine("                        (` ^'\"`-' \")");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"I hope whatever was behind door {choice} was worth it...");
                Console.ReadKey();
            }
        }

        private static void ShowDoor()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("     /|");
            Console.WriteLine("    / |");
            Console.WriteLine("   /__|______");
            Console.WriteLine("  |  __  __  |");
            Console.WriteLine("  | |  ||  | | ");
            Console.WriteLine("  | |__||__| |");
            Console.WriteLine("  |  __  __()|   ...opening...");
            Console.WriteLine("  | |  ||  | |");
            Console.WriteLine("  | |  ||  | |");
            Console.WriteLine("  | |__||__| |");
            Console.WriteLine("  |__________|");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
