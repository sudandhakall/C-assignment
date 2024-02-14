//Author: Sudan Krishna Dhakal
// Std Id : C0901145

class Interval
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a real number
        Console.Write("Enter a real number (or type 'exit' to quit): ");

        // Loop indefinitely
        while (true)
        {
            // Prompt the user for input
            Console.WriteLine("Enter a real number");

            // Read the input from the console
            string input = Console.ReadLine();

            // Check if the input is 'exit' to quit the program
            if (input.ToLower() == "exit")
                break;

            // Declare a variable to store the parsed real number
            double x;

            // Attempt to parse the input into a double
            if (!double.TryParse(input, out x))
            {
                // If parsing fails, print an error message and continue to the next iteration
                Console.WriteLine("Invalid input. Please enter a valid real number.");
                continue; // Skip the rest of the loop and start again
            }

            // Check if the input number belongs to the defined set I
            bool belongsToI = (!(x < 2) && x < 3) || (!(x <= 0) && x <= 1) || (!(x < -10) && x <= -2);

            // Print whether the input number belongs to set I or not
            if (belongsToI)
            {
                Console.Write("x belongs to I ");
            }
            else
            {
                Console.Write("x does not belong to I ");
            }
        }
    }
}
