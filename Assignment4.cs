//Name: Sudan Krishna Dhakal
// STd: C0901145

using System;
using System.Collections.Generic;
using System.Globalization;

public class Circle
{
    // Properties for the X and Y coordinates of the circle's center, and its Radius.
    public double X { get; }
    public double Y { get; }
    public double Radius { get; }

    // Constructor that initializes a new Circle with given coordinates and radius.
    // Throws an exception if the radius is not a positive number, ensuring data integrity.
    public Circle(double x, double y, double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than zero.");
        }

        X = x;
        Y = y;
        Radius = radius;
    }

    // Method to calculate the perimeter of the circle. Uses the formula 2πr.
    public double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }

    // Method to calculate the surface area of the circle. Uses the formula πr^2.
    public double Surface()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    // Method to print detailed information about the circle, including its center, radius, perimeter, and surface area.
    public void PrintInfo()
    {
        Console.WriteLine($"Circle with center: ({X}, {Y}) and radius: {Radius}");
        Console.WriteLine($"Perimeter: {Perimeter()}");
        Console.WriteLine($"Surface: {Surface()}");
    }

    // Method to determine if a given point (x, y) is inside the circle.
    // This is done by comparing the distance from the point to the circle's center with the radius of the circle.
    public bool IsPointInside(double x, double y)
    {
        return Math.Sqrt(Math.Pow(x - X, 2) + Math.Pow(y - Y, 2)) <= Radius;
    }
}

public class Program
{
    // Main entry point of the program. Includes try-catch for global error handling.
    public static void Main()
    {
        try
        {
            // Process of creating circles and displaying their information.
            var circles = CreateCircles();
            foreach (var circle in circles)
            {
                circle.PrintInfo();
            }

            // Getting a point from the user and checking its presence in each circle.
            var point = GetPoint();
            CheckPointInCircles(circles, point);
        }
        catch (Exception ex)
        {
            // Catches and displays unexpected errors, providing feedback for debugging.
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    // Method for creating multiple Circle instances based on user input.
    // It ensures that the user enters a valid number of circles and valid parameters for each circle.
    private static List<Circle> CreateCircles()
    {
        int num = ReadInt("Enter the number of circles: ", "Invalid number of circles.");
        var circles = new List<Circle>();

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine($"Circle {i + 1}:");

            double x = ReadDouble("Enter the center x-coordinate: ");
            double y = ReadDouble("Enter the center y-coordinate: ");
            double r = ReadDouble("Enter the radius: ", "Invalid radius.", value => value > 0);

            circles.Add(new Circle(x, y, r));
        }

        return circles;
    }

    // Method to prompt the user for a point (x, y). Validates the input to ensure it is a valid double.
    private static Tuple<double, double> GetPoint()
    {
        double x = ReadDouble("Enter the x-coordinate of the point: ");
        double y = ReadDouble("Enter the y-coordinate of the point: ");
        return Tuple.Create(x, y);
    }

    // Method to check if the given point is inside each of the circles. Provides user feedback for each check.
    private static void CheckPointInCircles(List<Circle> circles, Tuple<double, double> point)
    {
        for (int i = 0; i < circles.Count; i++)
        {
            if (circles[i].IsPointInside(point.Item1, point.Item2))
            {
                Console.WriteLine($"Point ({point.Item1}, {point.Item2}) is inside Circle {i + 1}.");
            }
            else
            {
                Console.WriteLine($"Point ({point.Item1}, {point.Item2}) is not inside Circle {i + 1}.");
            }
        }
    }

    // Utility method for reading and validating an integer value from the console.
    // It repeats the prompt until a valid integer is entered, preventing crashes due to invalid input.
    private static int ReadInt(string prompt, string errorMessage = "Invalid input.")
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }

            Console.WriteLine(errorMessage);
        }
    }

    // Utility method for reading and validating a double value from the console.
    // Incorporates additional validation logic through a lambda expression (validator) to provide more flexibility.
    private static double ReadDouble(string prompt, string errorMessage = "Invalid input.", Func<double, bool> validator = null)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out double result)
                && (validator == null || validator(result)))
            {
                return result;
            }

            Console.WriteLine(errorMessage);
        }
    }
}
