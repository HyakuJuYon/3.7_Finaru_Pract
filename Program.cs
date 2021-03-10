using System;

namespace _3._7_Finaru_Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name, please: ");

            var name = Console.ReadLine();

            Console.WriteLine("Enter your age, please: ");

            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0} and your age is {1}", name, age);

            Console.WriteLine("Would you be so kind to answer when you were born?: ");

            var birthdate = Console.ReadLine();

            Console.WriteLine("You were born on: {0}", birthdate);
        }
    }
}
