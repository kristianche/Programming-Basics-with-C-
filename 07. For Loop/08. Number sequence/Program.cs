// See https://aka.ms/new-console-template for more information
var n = int.Parse(Console.ReadLine());
var maxNumber = -2000000000000;
var minNumber = 20000000000000;

for (var i = 1; i <= n; i++)
{
    var number = int.Parse(Console.ReadLine());

    if (number > maxNumber)
    {
        maxNumber = number;
    }
    
    if (number < minNumber)
    {
        minNumber = number;
    }
}

Console.WriteLine($"Max number: {maxNumber}");
Console.WriteLine($"Min number: {minNumber}");
