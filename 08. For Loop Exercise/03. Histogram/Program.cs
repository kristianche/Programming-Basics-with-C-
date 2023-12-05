// See https://aka.ms/new-console-template for more information
var totalNumbers = int.Parse(Console.ReadLine());

var p1Numbers = 0;
var p2Numbers = 0;
var p3Numbers = 0;
var p4Numbers = 0;
var p5Numbers = 0;

for (var i = 0; i < totalNumbers; i++)
{
    var number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        p1Numbers++;
    }
    else if (200 <= number && number <= 399)
    {
        p2Numbers++;
    }
    else if (400 <= number && number <= 599)
    {
        p3Numbers++;
    }
    else if (600 <= number && number <= 799)
    {
        p4Numbers++;
    }
    else if (800 <= number && number <= 1000)
    {
        p5Numbers++;
    }
}

var p1Percent = (double)p1Numbers / totalNumbers * 100;
var p2Percent = (double)p2Numbers / totalNumbers * 100;
var p3Percent = (double)p3Numbers / totalNumbers * 100;
var p4Percent = (double)p4Numbers / totalNumbers * 100;
var p5Percent = (double)p5Numbers / totalNumbers * 100;

Console.WriteLine($"{p1Percent:F2}%");
Console.WriteLine($"{p2Percent:F2}%");
Console.WriteLine($"{p3Percent:F2}%");
Console.WriteLine($"{p4Percent:F2}%");
Console.WriteLine($"{p5Percent:F2}%");