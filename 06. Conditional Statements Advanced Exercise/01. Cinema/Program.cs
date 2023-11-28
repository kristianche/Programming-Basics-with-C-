// See https://aka.ms/new-console-template for more information
var movieType = Console.ReadLine();
var rows = int.Parse(Console.ReadLine());
var columns = int.Parse(Console.ReadLine());

var income = 0.0;

if (movieType == "Premiere")
{
    income = (columns * rows) * 12;
} 
else if (movieType == "Normal")
{
    income = (columns * rows) * 7.50;
} 
else if (movieType == "Discount")
{
    income = (columns * rows) * 5;
}

Console.WriteLine($"{income:F2} leva");
