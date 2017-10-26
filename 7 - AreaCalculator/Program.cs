using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose a shape:");
                Console.WriteLine("1 - Rectangle");
                Console.WriteLine("2 - Triangle");
                Console.WriteLine("3 - Circle");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("---------------");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------");

                if (choice == 1)
                {
                    getRectArea();
                }
                else if (choice == 2)
                {
                    getTriArea();
                }
                else if (choice == 3)
                {
                    getCircArea();
                }
                else if (choice == 4)
                {
                }

            } while (choice != 4);
        }


        static void getRectArea()
        {
            Console.Write("Width: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + w * h);
            Console.ReadKey();
        }

        static void getTriArea()
        {
            Console.Write("Width: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (w * h) / 2);
            Console.ReadKey();
        }

        static void getCircArea()
        {
            Console.Write("Radius: ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + Math.Pow(Math.PI * r, 2));
            Console.ReadKey();
        }
    }
}
