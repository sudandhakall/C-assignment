//Author: Sudan Krishna Dhakal
//Std:C0901145

using System;

class Program
{
    static void Main()
    {
        int number;

        // Repeat the procedure until a valid number is entered
        do
        {
            Console.Write("Enter a positive number less than 10: ");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number <= 0 || number >= 10);

        Console.WriteLine($"Times table of number {number}:");

        // Calculate and print the times table
        for (int i = 1; i <= 9; i++)
        {
            int result = i * number;
            Console.WriteLine($"{i} * {number} = {result}");
        }

        Console.WriteLine("---------");
    }
}


