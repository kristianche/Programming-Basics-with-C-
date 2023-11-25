// See https://aka.ms/new-console-template for more information
var name = Console.ReadLine();
var projects = int.Parse(Console.ReadLine());

var hours = projects * 3;

Console.WriteLine($"The architect {name} will need {hours} hours to complete {projects} project/s.");
