//Author: SUdan Krishna Dhakal -145

using System;
//reading input from user and storing in a variable
Console.WriteLine("Enter a (int) :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b (int) :");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c (int) :");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter X (double) :");
double x = Convert.ToDouble(Console.ReadLine());
//calculation
int sum = a + b;
double halfSum = (a + b) / 2.0;
double xCubed = Math.Pow(x, 3);
double xSquared = Math.Pow(x, 2);
double result = (halfSum * xCubed) + (Math.Pow(sum, 2) * xSquared) + a + b + c;
Console.WriteLine("The value of polynomial is " + result);


