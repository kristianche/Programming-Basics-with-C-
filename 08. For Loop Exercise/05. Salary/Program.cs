// See https://aka.ms/new-console-template for more information
var openSites = int.Parse(Console.ReadLine());
var salary = int.Parse(Console.ReadLine());

for (int i = 1; i <= openSites; i++)
{
    if (salary == 0)
    {
        break;
    }

    var site = Console.ReadLine();

    if (site == "Facebook")
    {
        salary -= 150;
    }
    else if (site == "Instagram")
    {
        salary -= 100;
    }
    else if (site == "Reddit")
    {
        salary -= 50;
    }
}

if (salary  == 0)
{
    Console.WriteLine("You have lost your salary.");
} else
{
    Console.WriteLine(salary);
}
