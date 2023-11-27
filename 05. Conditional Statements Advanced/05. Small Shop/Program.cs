// See https://aka.ms/new-console-template for more information
var product = Console.ReadLine();
var city = Console.ReadLine();
var quantity = double.Parse(Console.ReadLine());
var productPrice = 0.0;

if (product == "coffee")
{
    if (city == "Sofia")
    {
        productPrice = 0.50;
    } else if (city == "Plovdiv")
    {
        productPrice = 0.40;
    } else if (city == "Varna")
    {
        productPrice = 0.45;
    }
}
else if (product == "water")
{
    if (city == "Sofia")
    {
        productPrice = 0.80;
    }
    else if (city == "Plovdiv")
    {
        productPrice = 0.70;
    }
    else if (city == "Varna")
    {
        productPrice = 0.70;
    }
}
else if (product == "beer")
{
    if (city == "Sofia")
    {
        productPrice = 1.20;
    }
    else if (city == "Plovdiv")
    {
        productPrice = 1.15;
    }
    else if (city == "Varna")
    {
        productPrice = 1.10;
    }
}
else if (product == "sweets")
{
    if (city == "Sofia")
    {
        productPrice = 1.45;
    }
    else if (city == "Plovdiv")
    {
        productPrice = 1.30;
    }
    else if (city == "Varna")
    {
        productPrice = 1.35;
    }
}
else if (product == "peanuts")
{
    if (city == "Sofia")
    {
        productPrice = 1.60;
    }
    else if (city == "Plovdiv")
    {
        productPrice = 1.50;
    }
    else if (city == "Varna")
    {
        productPrice = 1.55;
    }
}

var totalCost = productPrice * quantity;

Console.WriteLine(totalCost);