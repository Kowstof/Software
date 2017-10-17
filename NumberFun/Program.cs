using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("| Welcome to the NUMBER MASHER! |");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("Please enter X:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Y:");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            Console.WriteLine($"{x} + {y} = {(x + y)}");
            Console.WriteLine($"{x} - {y} = {(x - y)}");
            Console.WriteLine($"{x} × {y} = {(x * y)}");
            Console.WriteLine($"{x} ÷ {y} = {(x / y)}");

            Console.ReadLine();
        }
    }
}
