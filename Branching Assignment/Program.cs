using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main()
        {
            // Welcome message
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");

            // Enter package weight
            Console.WriteLine("Enter Package Weight: ");
            float package_weight = Convert.ToSingle(Console.ReadLine());

            // Check package weight
            if (package_weight > 50)
            {
                // Package weight is greater than 50, display message and exit program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                return;
            }

            // Enter package width
            Console.WriteLine("Enter Package Width: ");
            float package_width = Convert.ToSingle(Console.ReadLine());

            // Enter package height
            Console.WriteLine("Enter Package Height: ");
            float package_height = Convert.ToSingle(Console.ReadLine());

            // Enter package length
            Console.WriteLine("Enter Package Length: ");
            float package_length = Convert.ToSingle(Console.ReadLine());

            // Compute for total package dimension (W + H + L)
            float package_dimensions = package_width + package_height + package_length;

            // Check total package dimension
            if (package_dimensions > 50)
            {
                // Total package dimension is greater than 50, display message and exit program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.Read();
                return;
            }

            // Compute for package estimated quote ((Height * Lenth * Width * Weight) / 100)
            float package_quote = (package_height * package_length * package_width * package_weight) / 100;

            // Display package estimated quote and exit program
            Console.WriteLine("Your estimated total for shipping this package is: $" + package_quote.ToString("F"));
            Console.WriteLine("Thank you!");
            Console.Read();
        }
    }
}
