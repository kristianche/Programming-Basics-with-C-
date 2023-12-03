// See https://aka.ms/new-console-template for more information
var n = int.Parse(Console.ReadLine());
var sum = 0;

for (var i = 1; i <= n; i++)
{
    var number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine(sum);
