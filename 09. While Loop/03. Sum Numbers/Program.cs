// See https://aka.ms/new-console-template for more information
var desiredSum = int.Parse(Console.ReadLine());
var number = int.Parse(Console.ReadLine());
var sum = number;

while (sum < desiredSum)
{
    number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine(sum);
