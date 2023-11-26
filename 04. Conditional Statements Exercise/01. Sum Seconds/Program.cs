// See https://aka.ms/new-console-template for more information
var minutes1 = int.Parse(Console.ReadLine());
var minutes2 = int.Parse(Console.ReadLine());
var minutes3 = int.Parse(Console.ReadLine());

var totalTime = minutes1 + minutes2 + minutes3;

var hours = totalTime / 60;
var minutes = totalTime % 60;

if (minutes <= 9)
{
    Console.WriteLine($"{hours}:0{minutes}");
} else
{
    Console.WriteLine($"{hours}:{minutes}");
}
