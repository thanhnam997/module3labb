using System;

namespace TacoBurritoLab
{
    class Program
    {
        // Main method - magical method, it's called when the program runs
        static void Main(string[] args)
        {
            // Output a welcome message
            Console.WriteLine("Welcome to the Taco & Burrito Decision Maker!");

            // Prompt the user for input and get the input - the hunger level
            Console.WriteLine("How hungry are you (1-10)?");
            int hungerLevel = int.Parse(Console.ReadLine());

            // Use an if-else if-else statement to suggest food based on the hunger level
            if (hungerLevel >= 8)
            {
                Console.WriteLine("You're super hungry! Order both tacos and burritos.");
            }
            else if (hungerLevel >= 5)
            {
                Console.WriteLine("You're moderately hungry. Go for tacos!");
            }
            else
            {
                Console.WriteLine("You're not that hungry. Opt for a burrito.");
            }

            // Ternary operator (if-else) makes a final recommendation on the tacos or burritos
            string recommendation = (hungerLevel >= 5) ? "Tacos" : "Burritos";
            Console.WriteLine($"My recommendation: {recommendation}");

            // After the ternary operator
            switch (hungerLevel)
            {
                case 10:
                    Console.WriteLine("You're a taco and burrito champion!");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Taco time!");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Burrito it is!");
                    break;
                default:
                    Console.WriteLine("Maybe just grab a snack.");
                    break;
            }
        } // end Main method
    } // end Program class
} // end namespace
