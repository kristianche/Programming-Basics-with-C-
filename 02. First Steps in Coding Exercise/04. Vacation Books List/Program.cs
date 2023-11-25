// See https://aka.ms/new-console-template for more information
var pages = int.Parse(Console.ReadLine());
var pagesPerHour = int.Parse(Console.ReadLine());
var days = int.Parse(Console.ReadLine());

var hoursPerDay = (pages / pagesPerHour) / days;

Console.WriteLine(hoursPerDay);
