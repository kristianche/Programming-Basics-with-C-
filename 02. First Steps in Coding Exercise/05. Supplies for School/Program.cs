// See https://aka.ms/new-console-template for more information
var pensCount = double.Parse(Console.ReadLine());
var markersCount = double.Parse(Console.ReadLine());
var boardClean = double.Parse(Console.ReadLine());
var discountPercent = double.Parse(Console.ReadLine()) / 100;

var pensPrice = pensCount * 5.80;
var markersPrice = markersCount * 7.20;
var boardCleanPrice = boardClean * 1.20;

var totalPrice = (pensPrice + markersPrice + boardCleanPrice) - ((pensPrice + markersPrice + boardCleanPrice) * discountPercent);

Console.WriteLine(totalPrice);