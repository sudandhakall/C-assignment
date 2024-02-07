using System;

class RoseBlanches
{
    static void Main()
    {
        // Input the amount of money received
        Console.Write("How much did you receive money ($)? ");
        double totalMoney = double.Parse(Console.ReadLine());

        // Calculate amounts for books and supplies
        double bookAndSupplies = totalMoney * 0.75;
        double totalRemaining = 0.00f;
        // Calculate amounts for coffees, Flash Computer, and subway tickets
        double coffees = ((totalMoney-bookAndSupplies) / 3)/2;
        totalRemaining += (coffees - (int)coffees)*2;
        double flashComputerNumbers = ((totalMoney - bookAndSupplies) / 3)/4;
        totalRemaining += (flashComputerNumbers - (int)flashComputerNumbers) * 4;
        double subwayTickets = ((totalMoney - bookAndSupplies ) /3)/3;
        // Calculate remaining money for white roses
        totalRemaining += (subwayTickets - (int)subwayTickets) * 3;

        // Display the results
        Console.WriteLine($"Book and Supplies: {bookAndSupplies:C}");
        Console.WriteLine($"You can then buy:");
        Console.WriteLine($"{(int)coffees} coffees");
        Console.WriteLine($"{(int)flashComputerNumbers} Flash Computer Numbers");
        Console.WriteLine($"{(int)subwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {(int)totalRemaining:C} for the white roses.");
    }
}
