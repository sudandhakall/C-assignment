//Author: Sudan Krishna Dhakal
///Std ID: C0901145
using System;
class Program
{
    static void Main()
    {
/////////-----------------------------------------------------------------------------------/////////////////

//1.If statement to exchange values if the first integer is greater than the second:

        // Taking user input for the first number
        Console.Write("Enter the first number: ");
        int firstVariable = Convert.ToInt32(Console.ReadLine());

        // Taking user input for the second number
        Console.Write("Enter the second number: ");
        int secondVariable = Convert.ToInt32(Console.ReadLine());

        // If statement to exchange values if the first integer is greater than the second
        if (firstVariable > secondVariable)
        {
            int temp = firstVariable;
            firstVariable = secondVariable;
            secondVariable = temp;
        }

        // Printing the swapped values
        Console.WriteLine("First variable: " + firstVariable);
        Console.WriteLine("Second variable: " + secondVariable);

/////////-----------------------------------------------------------------------------------/////////////////

//2.Program to show the sign of the product of three real numbers

        // Taking user input for the three numbers
        Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            // Logic to determine the sign of the product
            int sign = 1;

            if (num1 < 0)
                sign *= -1;
            if (num2 < 0)
                sign *= -1;
            if (num3 < 0)
                sign *= -1;

            // Displaying the sign of the product
            if (sign == 1)
                Console.WriteLine("The product is positive.");
            else if (sign == -1)
                Console.WriteLine("The product is negative.");
            else
                Console.WriteLine("At least one of the numbers is zero, so the product is zero.");

/////////-----------------------------------------------------------------------------------/////////////////

//3 Program to find the biggest of three integers using nested if statements:


        // Taking user input for the three numbers
        Console.Write("Enter the first number: ");
        int input1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int input2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int input3 = Convert.ToInt32(Console.ReadLine());

        // Logic to find the biggest number
        int biggest;

        if (input1 >= input2)
        {
            if (input1 >= input3)
                biggest = input1;
            else
                biggest = input3;
        }
        else
        {
            if (input2 >= input3)
                biggest = input2;
            else
                biggest = input3;
        }

        // Displaying the biggest number
        Console.WriteLine("The biggest number is: " + biggest);

/////////-----------------------------------------------------------------------------------/////////////////
///4.  Program to sort 3 real values in descending order using nested if statements:

        // Input three real numbers
        Console.Write("Enter first number: ");
            double var1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double var2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third number: ");
            double var3 = Convert.ToDouble(Console.ReadLine());

            // Sort the numbers in descending order using nested if statements
            if (var1 >= var2)
            {
                if (var1 >= var2)
                    Console.WriteLine("Sorted numbers in descending order: {0}, {1}, {2}", var1, var2, var3);
                else if (num1 >= num3)
                    Console.WriteLine("Sorted numbers in descending order: {0}, {1}, {2}", var2, var1, var3);
                else
                    Console.WriteLine("Sorted numbers in descending order: {0}, {1}, {2}", var3, var1, var2);
            }
            else
            {
                if (num1 >= num3)
                    Console.WriteLine("Sorted numbers in descending order: {0}, {1}, {2}", var2, var1, var3);
                else if (num2 >= num3)
                    Console.WriteLine("Sorted numbers in descending order: {0}, {1}, {2}", var2, var3, var1);
                else
                    Console.WriteLine("Sorted numbers in descending order: {0}, {1}, {2}", var3, var2, var1);
            }

}
}
