// See https://aka.ms/new-console-template for more information
var depositSum = double.Parse(Console.ReadLine());
var months = int.Parse(Console.ReadLine());
var percent = double.Parse(Console.ReadLine());

var result = depositSum + months * ((depositSum * (percent / 100)) / 12);

Console.WriteLine(result);