// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

var actorName = Console.ReadLine();
var points = double.Parse(Console.ReadLine());
var judgesCount = int.Parse(Console.ReadLine());

for (var i = 1; i <= judgesCount; i++)
{
    var judgeName = Console.ReadLine();
    var givenPoints = double.Parse(Console.ReadLine());
    points += (givenPoints * judgeName.Length) / 2;

    if (points >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
        break;
    }
}

if (points < 1250.5)
{
    Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - points):F1} more!");
}