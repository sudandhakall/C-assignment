//Author: SUdan Krishna Dhakal -145

using System;
// taking the age as input from the user
Console.WriteLine("provide your age");
string strAge = Console.ReadLine();
//checking if the age is valid or not
int validAge = 0;
bool chkAge = int.TryParse(strAge, out validAge);
if (chkAge == true)
{
    int dateOfYear = Convert.ToInt32(System.DateTime.Now.Year) - validAge;
    Console.WriteLine("Your year of birth  is " + dateOfYear);
}
else
{
    Console.WriteLine("Please  enter valid age");
}

