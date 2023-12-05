// See https://aka.ms/new-console-template for more information
var n = int.Parse(Console.ReadLine());
var sum = 0;
var max = int.MinValue;

for (var i = 0; i < n; i++)
{
    var number = int.Parse(Console.ReadLine());
    sum += number;

    if (number > max)
    {
        max = number;
    }

}

if (max == sum - max)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {max}");
} 
else
{
    var difference = Math.Abs(max - (sum - max));
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {difference}");
}
