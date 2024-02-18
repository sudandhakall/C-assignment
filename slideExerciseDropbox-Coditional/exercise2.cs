//Author: Sudan Krishna Dhakal
//Std:C0901145


using System;

class Program
{
    static void Main()
    {
        // Problem 1: Displaying the name of a digit in English
        Console.Write("Enter a digit (0-9): ");
        int digit = Convert.ToInt32(Console.ReadLine());

        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("Invalid input! Please enter a digit between 0 and 9.");
                break;
        }

        // Problem 2: Calculating and printing the real roots of a quadratic equation
        Console.WriteLine("\nEnter the coefficients of the quadratic equation (ax^2 + bx + c = 0):");

        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Root 1 = {0}, Root 2 = {1}", root1, root2);
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("Root = {0}", root);
        }
        else
        {
            Console.WriteLine("The quadratic equation has no real roots.");
        }

        // Problem 3: Finding the greatest of given 5 variables
        Console.WriteLine("\nEnter five numbers:");

        double max = double.MinValue;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num > max)
                max = num;
        }

        Console.WriteLine($"The greatest number is: {max}");
    }
}
