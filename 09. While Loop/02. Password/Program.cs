// See https://aka.ms/new-console-template for more information
var username = Console.ReadLine();
var password = Console.ReadLine();

var input = Console.ReadLine();

while (input != password)
{
    input = Console.ReadLine();
}

Console.WriteLine($"Welcome {username}!");
