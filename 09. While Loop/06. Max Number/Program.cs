// See https://aka.ms/new-console-template for more information
var max = int.MinValue;

while (true)
{
    var command = Console.ReadLine();

    if (command == "Stop")
    {
        break;
    }

    var number = int.Parse(command);

    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine(max);

