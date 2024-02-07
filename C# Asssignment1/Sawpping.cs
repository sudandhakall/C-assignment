//Author: SUdan Krishna Dhakal -145

using System;
//reading input from user and storing in a variable
Console.WriteLine("Enter X");
string var1 = Console.ReadLine();
Console.WriteLine("Enter Y");
string var2 = Console.ReadLine();
Console.WriteLine("Before Swaping: X :" + var1 + ", Y: " + var2);
//Swapping the value using third variable
string temp = var2;
var2 = var1;
var1 = temp;
Console.WriteLine("After Swaping: X :" + var1 + ", Y: " + var2);





