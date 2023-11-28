// See https://aka.ms/new-console-template for more
double budjet = double.Parse(Console.ReadLine());
string seazon = Console.ReadLine();


double cena = budjet * 0.9;
string destination = "Europe";
string vidPoch = "Hotel";

if (budjet <= 100)
{
    destination = "Bulgaria";
    switch (seazon)
    {
        case "summer": cena = budjet * 0.3; vidPoch = "Camp"; break;
        case "winter": cena = budjet * 0.7; vidPoch = "Hotel"; break;

    }
}
else if (budjet <= 1000)
{
    destination = "Balkans";
    switch (seazon)
    {
        case "summer": cena = budjet * 0.4; vidPoch = "Camp"; break;
        case "winter": cena = budjet * 0.8; vidPoch = "Hotel"; break;

    }
}





Console.WriteLine($"Somewhere in {destination}");


Console.WriteLine($"{vidPoch} - {cena:f2}");
