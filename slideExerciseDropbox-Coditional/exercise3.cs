//Author: Sudan Krishna Dhakal
//Std:C0901145


using System;

class Program
{
    static void Main()
    {
// Problem 1: Depending on user choice, input int, double, or string variable and perform specific operations
        Console.WriteLine("Choose the type of variable:");
        Console.WriteLine("1. Integer");
        Console.WriteLine("2. Double");
        Console.WriteLine("3. String");

        Console.Write("Enter your choice (1, 2, or 3): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // If choice is 1, input an integer and increment it by 1
                Console.Write("Enter an integer: ");
                int intValue = Convert.ToInt32(Console.ReadLine());
                intValue++;
                Console.WriteLine("Modified integer value: " + intValue);
                break;
            case 2:
                // If choice is 2, input a double and increment it by 1
                Console.Write("Enter a double: ");
                double doubleValue = Convert.ToDouble(Console.ReadLine());
                doubleValue++;
                Console.WriteLine("Modified double value: " + doubleValue);
                break;
            case 3:
                // If choice is 3, input a string and append "*" to it
                Console.Write("Enter a string: ");
                string stringValue = Console.ReadLine();
                stringValue += "*";
                Console.WriteLine("Modified string value: " + stringValue);
                break;
            default:
                // Handle invalid choice
                Console.WriteLine("Invalid choice! Please enter 1, 2, or 3.");
                break;
        }


// Problem 2: Check if the sum of some subset of 5 integer numbers is 0
        Console.WriteLine("\nProblem 2:");

        // Given 5 integer numbers
        int[] numbers = { 3, -2, 1, 1, 8 };
        bool foundSubset = false;

        // Iterate through each number to find subsets
        for (int i = 0; i < numbers.Length; i++)
        {
            int sum = numbers[i];
            if (sum == 0)
            {
                // If a single number itself is 0, print it as a subset
                Console.WriteLine("Subset found: " + numbers[i]);
                foundSubset = true;
            }
            for (int j = i + 1; j < numbers.Length; j++)
            {
                // Add subsequent numbers to form subsets
                sum += numbers[j];
                if (sum == 0)
                {
                    // If the sum of a subset is 0, print the subset
                    for (int k = i; k <= j; k++)
                    {
                        if (k == i)
                            Console.Write("Subset found: " + numbers[k]);
                        else
                            Console.Write(" + " + numbers[k]);
                    }
                    Console.WriteLine();
                    foundSubset = true;
                }
            }
        }

        // If no subset with sum equal to 0 is found, print a message
        if (!foundSubset)
            Console.WriteLine("No subset with sum equal to 0 found.");
    }
}

