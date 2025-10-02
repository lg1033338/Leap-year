// Ask the User to give out a year
Console.Write("Please give a year darling: ");
// Convert it to an int
int x = Convert.ToInt32(Console.ReadLine());

// If its divisible of 400 then show its a leap year
if (x % 400 == 0)
{
    Console.WriteLine("That year is a leap year darling <3");
}
// If its divisible of 100 then show its not a leap year
else if (x % 100 == 0)
{
    Console.WriteLine("That is no leap year darling!");
}
// If its divisible of 4 then show its a leap year
else if (x % 4 == 0)
{
    Console.WriteLine("That year is a leap year darling <3");
}
else
// If none else  then show its not a leap year
{
    Console.WriteLine("That is no leap year darling!");
}