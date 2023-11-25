// See https://aka.ms/new-console-template for more information
var dogFood = int.Parse(Console.ReadLine());
var catFood = int.Parse(Console.ReadLine());

var dogFoodPrice = dogFood * 2.50;
var catFoodPrice = catFood * 4;

Console.WriteLine($"{catFoodPrice + dogFoodPrice} lv.");
