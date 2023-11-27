// See https://aka.ms/new-console-template for more information
var hour = int.Parse(Console.ReadLine());
var day = Console.ReadLine();

if (day == "Sunday")
{
    Console.WriteLine("closed");
} else
{
    if (hour >= 10 && hour <= 18)
    {
        Console.WriteLine("open");
    } else
    {
        Console.WriteLine("closed");
    }
}
