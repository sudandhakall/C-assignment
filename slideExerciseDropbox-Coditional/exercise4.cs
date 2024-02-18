//Author: Sudan Krishna Dhakal
//Std:C0901145


using System;

class Program
{
    static void Main()
    {
        // Prompting the user to enter a digit between 1 and 9
        Console.Write("Enter a digit between 1 and 9: ");
        char input = Console.ReadKey().KeyChar; // Reading a single character from the console input
        Console.WriteLine(); // Moving to the next line for better formatting

        int score;
        bool isValidInput = int.TryParse(input.ToString(), out score); // Parsing the input character to an integer

        if (isValidInput && score >= 1 && score <= 9)
        {
            // If the input is valid and within the range of 1 to 9
            int newScore;

            // Applying bonus scores based on the value of the input digit using a switch statement
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    newScore = score * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    newScore = score * 100;
                    break;
                case 7:
                case 8:
                case 9:
                    newScore = score * 1000;
                    break;
                default:
                    newScore = 0;
                    break;
            }

            // Displaying the new calculated score
            Console.WriteLine("New score: " + newScore);
        }
        else
        {
            // If the input is not valid or not within the range of 1 to 9
            Console.WriteLine("Error: Input must be a digit between 1 and 9.");
        }
    }
}


