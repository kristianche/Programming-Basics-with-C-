// See https://aka.ms/new-console-template for more information
string kindOfFlowers = Console.ReadLine();
int numOfFlowers = int.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());
double price = 0.0;

if (kindOfFlowers == "Roses")
{
    price = numOfFlowers * 5;
    if (numOfFlowers > 80)
    {
        price = price - price * 0.10;
    }
}
else if (kindOfFlowers == "Dahlias")
{
    price = numOfFlowers * 3.80;
    if (numOfFlowers > 90)
    {
        price = price - price * 0.15;
    }
}
else if (kindOfFlowers == "Tulips")
{
    price = numOfFlowers * 2.80;
    if (numOfFlowers > 80)
    {
        price = price - price * 0.15;
    }
}
else if (kindOfFlowers == "Narcissus")
{
    price = numOfFlowers * 3;
    if (numOfFlowers < 120)
    {
        price = price + price * 0.15;
    }

}
else if (kindOfFlowers == "Gladiolus")
{
    price = numOfFlowers * 2.50;
    if (numOfFlowers < 80)
    {
        price = price + price * 0.20;
    }
}
if (budget < price)
{
    Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
}
else
{
    Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {kindOfFlowers} and {(budget - price):f2} leva left.");
}
