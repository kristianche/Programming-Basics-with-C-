// See https://aka.ms/new-console-template for more information
var number = int.Parse(Console.ReadLine());
var k = 1;

while (k <= number)
{
    Console.WriteLine(k);
    k = k * 2 + 1;
}