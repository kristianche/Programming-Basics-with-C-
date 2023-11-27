// See https://aka.ms/new-console-template for more information
double price = 0.00;

var fruit = Console.ReadLine().ToLower();
string day = Console.ReadLine().ToLower();
double quantity = double.Parse(Console.ReadLine());

if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
{
    switch (fruit)
    {
        case "banana": price = 2.50; break;
        case "apple": price = 1.20; break;
        case "orange": price = 0.85; break;
        case "grapefruit": price = 1.45; break;
        case "kiwi": price = 2.70; break;
        case "pineapple": price = 5.50; break;
        case "grapes": price = 3.85; break;
        default: Console.WriteLine("error"); break;
    }
}
else if (day == "saturday" || day == "sunday")
{
    switch (fruit)
    {
        case "banana": price = 2.70; break;
        case "apple": price = 1.25; break;
        case "orange": price = 0.90; break;
        case "grapefruit": price = 1.60; break;
        case "kiwi": price = 3.00; break;
        case "pineapple": price = 5.60; break;
        case "grapes": price = 4.20; break;
        default: Console.WriteLine("error"); break;
    }
}
else
    Console.WriteLine("error");

double total = quantity * price;
if (total != 0)
{
    Console.WriteLine($"{total:f2}");
}
    