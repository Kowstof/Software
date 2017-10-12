using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start!");
            Console.ReadLine();
            Console.WriteLine("Oh no! The program failed! \nTry to override the ADP array, maybe it will back\nup the redundant microchip!");
            Console.ReadLine();
            Console.ReadLine();
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125);
            Console.WriteLine("You found a scret ;)");
            Console.ReadLine();
        }
    }
}
