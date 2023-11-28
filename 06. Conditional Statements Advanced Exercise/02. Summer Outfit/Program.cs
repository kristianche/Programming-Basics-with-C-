// See https://aka.ms/new-console-template for more information
var degrees = double.Parse(Console.ReadLine());
var timeOfTheDay = Console.ReadLine();
var outfit = "";
var shoes = "";

if (10 <= degrees && degrees <= 18)
{
    if (timeOfTheDay == "Morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    } 
    else if (timeOfTheDay == "Afternoon")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    } 
    else if (timeOfTheDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
else if (18 < degrees && degrees <= 24)
{
    if (timeOfTheDay == "Morning")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (timeOfTheDay == "Afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (timeOfTheDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}
else if (degrees >= 25)
{
    if (timeOfTheDay == "Morning")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (timeOfTheDay == "Afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else if (timeOfTheDay == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");