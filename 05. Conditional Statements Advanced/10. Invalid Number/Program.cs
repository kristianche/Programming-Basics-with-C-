// See https://aka.ms/new-console-template for more information
var number = int.Parse(Console.ReadLine());

var isValid = number >= 100 && number <= 200 || number == 0;

if (!isValid)
{
    Console.WriteLine("invalid");
}
