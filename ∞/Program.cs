using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much do you want to count to?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("-------");

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------");
            Console.WriteLine();

            Console.WriteLine("That was fun! Let's do it again! How much do you want to count to now?");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("-------");
            int counter = 1;
            while (counter <= num)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.ReadLine();
        }
    }
}
