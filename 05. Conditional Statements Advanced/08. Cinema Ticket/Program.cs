// See https://aka.ms/new-console-template for more information
var day = Console.ReadLine();
var ticketPrice = 0;

switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Friday":
        ticketPrice = 12;
        break;

    case "Wednesday":
    case "Thursday":
        ticketPrice = 14;
        break;

    case "Saturday":
    case "Sunday":
        ticketPrice = 16;
        break;
}

Console.WriteLine(ticketPrice);
