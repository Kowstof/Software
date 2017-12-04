using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Jeremiah", "Stanford", 32);
        }
    }

    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private bool sitting;
        private int steps;

        public Person (string firstName, string lastName, int age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            sitting = true;
            steps = 0;
        }

        public void ChangeName(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void ChangeNamePrompt()
        {
            Console.WriteLine($"Name is currently {this.firstName} {this.lastName}, enter new name.");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Walk(int steps)
        {
            if (sitting)
            {
                Console.WriteLine("You can't walk while you're sitting.");
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName} just walked {steps} steps.");
                this.steps += steps;
            }
        }

        public void Birthday()
        {
            age++;
        }

        public void PrintInfo()
        {
            if (sitting)
            {
                Console.WriteLine($"{firstName} {lastName} is {age} years old, is currently sitting and has taken {steps} steps.");
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName} is {age} years old, is currently standing and has taken {steps} steps.");
            }
        }

        public void Sit()
        {
            if (sitting)
            {
                Console.WriteLine($"{firstName} {lastName} is already sitting.");
            }
            else
            {
                sitting = true;
                Console.WriteLine($"{firstName} {lastName} is now sitting.");
            }
        }

        public void Stand()
        {
            if (sitting)
            {
                sitting = false;
                Console.WriteLine($"{firstName} {lastName} is now standing.");
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName} is already standing.");
            }
        }
    }
}
