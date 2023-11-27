// See https://aka.ms/new-console-template for more information
var number = int.Parse(Console.ReadLine());

if ((number <= 100 && number >= -100) && number != 0)
{
    Console.WriteLine("Yes");
} else
{
    Console.WriteLine("No");
}
