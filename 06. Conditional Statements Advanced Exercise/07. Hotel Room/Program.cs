// See https://aka.ms/new-console-template for more information
string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double studio = 0;
double apartment = 0;

switch (month)
{
    case "May":
    case "October":
        {
            studio = nights * 50.00;
            apartment = nights * 65.00;
            if (nights > 14) studio -= studio * 0.3;
            else if (nights > 7) studio -= studio * 0.05;
            break;
        }
    case "June":
    case "September":
        {
            studio = nights * 75.20;
            apartment = nights * 68.70;
            if (nights > 14) studio -= studio * 0.2;
            break;
        }
    case "July":
    case "August":
        {
            studio = nights * 76.00;
            apartment = nights * 77.00;
            break;
        }
}
if (nights > 14) apartment -= apartment * 0.1;

Console.WriteLine("Apartment: {0:f2} lv.", apartment);
Console.WriteLine("Studio: {0:f2} lv.", studio);
