// See https://aka.ms/new-console-template for more information
int groupsQty;
int peoplePerGroup = 0;
double totalPeople = 0;
int peak01 = 0;
int peak02 = 0;
int peak03 = 0;
int peak04 = 0;
int peak05 = 0;

double percPeak01 = 0;
double percPeak02 = 0;
double percPeak03 = 0;
double percPeak04 = 0;
double percPeak05 = 0;

groupsQty = int.Parse(Console.ReadLine());
for (int i = 0; i < groupsQty; i++)
{
    peoplePerGroup = int.Parse(Console.ReadLine());
    totalPeople += peoplePerGroup;
    if (peoplePerGroup <= 5) peak01 += peoplePerGroup;
    else if (peoplePerGroup <= 12) peak02 += peoplePerGroup;
    else if (peoplePerGroup <= 25) peak03 += peoplePerGroup;
    else if (peoplePerGroup <= 40) peak04 += peoplePerGroup;
    else if (peoplePerGroup > 40) peak05 += peoplePerGroup;
}

percPeak01 = (peak01 / totalPeople) * 100;
percPeak02 = (peak02 / totalPeople) * 100;
percPeak03 = (peak03 / totalPeople) * 100;
percPeak04 = (peak04 / totalPeople) * 100;
percPeak05 = (peak05 / totalPeople) * 100;

Console.WriteLine($"{percPeak01:f2}%");
Console.WriteLine($"{percPeak02:f2}%");
Console.WriteLine($"{percPeak03:f2}%");
Console.WriteLine($"{percPeak04:f2}%");
Console.WriteLine($"{percPeak05:f2}%");
