// See https://aka.ms/new-console-template for more information
var studentName = Console.ReadLine();
var failedTimes = 0;
var year = 0;
var finalGrade = 0.0;

while (year <= 12)
{
    var grade = double.Parse(Console.ReadLine());

    if (grade < 4.00)
    {
        failedTimes++;
    } else
    {
        finalGrade += grade;
    }

    if (failedTimes == 2)
    {
        Console.WriteLine($"{studentName} has been excluded at {year} grade");
        break;
    }

    year++;
}

if (failedTimes != 2)
{
    Console.WriteLine($"{studentName} graduated. Average grade: {(finalGrade / 12):F2}");
}
