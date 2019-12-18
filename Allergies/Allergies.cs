using System;
using System.Collections.Generic;
using Allergies.Models;

namespace Allergies
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Allergy Score program!");
            CheckValidInput();
        }

        private static void CheckValidInput()
        {
            Console.Write("Enter your allergy score: ");
            int userInput;
            bool success = Int32.TryParse(Console.ReadLine(), out userInput);
            if (success) 
            {
                Score userScore = new Score(userInput);
                List<string> result = userScore.CheckAllergies();
                Console.WriteLine(string.Join(", ", result));
            }
            else 
            {
                Console.WriteLine("Invalid input!");
                CheckValidInput();
            }
        }
    }
}