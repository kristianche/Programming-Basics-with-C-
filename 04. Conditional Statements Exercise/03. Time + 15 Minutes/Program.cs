// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

var hours = int.Parse(Console.ReadLine());
var minutes = int.Parse(Console.ReadLine());

if (minutes + 15 >= 60)
{
    minutes = (15 + minutes) - 60;
    hours++;
    if (hours == 24)
    {
        hours = 0;
    }

} else
{
    minutes += 15;
}

if (minutes <= 9)
{
    Console.WriteLine($"{hours}:0{minutes}");
} else
{
    Console.WriteLine($"{hours}:{minutes}");
}
