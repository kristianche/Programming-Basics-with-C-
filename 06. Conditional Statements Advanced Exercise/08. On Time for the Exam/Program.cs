// See https://aka.ms/new-console-template for more information
int hourExam = int.Parse(Console.ReadLine());
int minuteExam = int.Parse(Console.ReadLine());
int hourArrival = int.Parse(Console.ReadLine());
int minuteArrival = int.Parse(Console.ReadLine());

int difference = (hourArrival * 60 + minuteArrival) - (hourExam * 60 + minuteExam);
int hh = Math.Abs(difference) / 60;
int mm = Math.Abs(difference) % 60;

if (difference == 0) Console.WriteLine("On time");
else if (difference > 0)
{
    Console.WriteLine("Late");
    if (hh == 0) Console.WriteLine("{0} minutes after the start", mm);
    else if (mm < 10) Console.WriteLine("{0}:0{1} hours after the start", hh, mm);
    else Console.WriteLine("{0}:{1} hours after the start", hh, mm);
}
else if (difference < 0 && difference >= -30)
{
    Console.WriteLine("On time");
    if (hh == 0) Console.WriteLine("{0} minutes before the start", mm);
    else if (mm < 10) Console.WriteLine("{0}:0{1} hours before the start", hh, mm);
    else Console.WriteLine("{0}:{1} hours before the start", hh, mm);
}
else if (difference < -30)
{
    Console.WriteLine("Early");
    if (hh == 0) Console.WriteLine("{0} minutes before the start", mm);
    else if (mm < 10) Console.WriteLine("{0}:0{1} hours before the start", hh, mm);
    else Console.WriteLine("{0}:{1} hours before the start", hh, mm);
}

