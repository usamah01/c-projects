using System;

namespace writeAndReadLineSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your name");

            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");

            Console.WriteLine("What is your age?");

            var age = Console.ReadLine();

            Console.WriteLine($"Your age is {age}");

            Console.WriteLine("What is your gender? Male or Female");

            var gender = Console.ReadLine();

            Console.WriteLine($"Your gender is {gender}");
             
            Console.WriteLine("Thank you for completing this short questionnaire");

            Console.ReadKey();

        }
    }
} 
