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

            Console.ReadLine();
        }
    }
}
