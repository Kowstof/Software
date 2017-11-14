using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___AgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whem were you born?");
            DateTime bday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            int age = DateTime.Today.Year - bday.Year;

            if (age < 13 && age >= 0)
            {
                Console.WriteLine("You're a tiny little munchkin!");
            }
            else if (age < 18 && age >= 13)
            {
                Console.WriteLine("You're a teen, huh?");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You're an adult! Congrats on life!");
            }
            else
            {
                Console.WriteLine("You shouldn't be here...");
            }

            Console.ReadKey();
        }
    }
}
