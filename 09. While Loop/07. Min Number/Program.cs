// See https://aka.ms/new-console-template for more information
using System.Data;

var min = int.MaxValue;

while (true)
{
    var command = Console.ReadLine();

    if (command == "Stop")
    {
        break;
    }

    var number = int.Parse(command);

    if (number < min)
    {
        min = number;
    }
}

Console.WriteLine(min);
