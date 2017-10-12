using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("User: ");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Authenticating...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine($"User recognized. Welcome, {name}");
            Console.ReadKey();
        }
    }
}
