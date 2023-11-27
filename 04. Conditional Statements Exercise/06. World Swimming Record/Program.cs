// See https://aka.ms/new-console-template for more information
var record = double.Parse(Console.ReadLine());
var distance = double.Parse(Console.ReadLine());
var secondsPer1Meter = double.Parse(Console.ReadLine());

var additionalTime = Math.Floor(distance / 15) * 12.5;
var totalTime = (distance * secondsPer1Meter) + additionalTime;

if (totalTime < record)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
} else
{
    Console.WriteLine($"No, he failed! He was {(totalTime - record):F2} seconds slower.");
}
