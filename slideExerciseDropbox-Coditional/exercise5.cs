//Author: Sudan Krishna Dhakal
//Std:C0901145


using System;

class Program
{
    // Arrays to store English words for numbers
    static string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    static string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    static void Main()
    {
        Console.Write("Enter a number between 0 and 999: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Number out of range. Please enter a number between 0 and 999.");
            return;
        }

        string result = ConvertToWords(number);
        Console.WriteLine($"The English pronunciation of {number} is: \"{result}\"");
    }

    static string ConvertToWords(int number)
    {
        if (number == 0)
            return "Zero";

        string words = "";

        if (number / 100 > 0)
        {
            words += units[number / 100] + " Hundred";
            number %= 100;
            if (number > 0)
                words += " and ";
        }

        if (number >= 20)
        {
            words += tens[number / 10];
            number %= 10;
            if (number > 0)
                words += " ";
        }

        if (number > 0 && number < 10)
            words += units[number];
        else if (number >= 10)
            words += teens[number - 10];

        return words;
    }
}
