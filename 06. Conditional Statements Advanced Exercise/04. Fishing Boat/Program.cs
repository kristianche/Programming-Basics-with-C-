// See https://aka.ms/new-console-template for more information
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int numOfFisherman = int.Parse(Console.ReadLine());
double price = 0;

switch (season)
{
    case "Spring":
        price = 3000;
        break;
    case "Summer":
    case "Autumn":
        price = 4200;
        break;
    default:
        price = 2600;
        break;
}
if (numOfFisherman <= 6)
{
    price = price - price * 0.10;
}
else if (numOfFisherman <= 11)
{
    price -= price * 0.15;
}
else
{
    price -= price * 0.25;
}
if (numOfFisherman % 2 == 0 && season != "Autumn")
{
    price -= price * 0.05;
}
if (price <= budget)
{
    Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
}
