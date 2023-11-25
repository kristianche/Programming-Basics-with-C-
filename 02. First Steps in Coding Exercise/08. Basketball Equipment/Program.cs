// See https://aka.ms/new-console-template for more information
double yearPaiment = double.Parse(Console.ReadLine());

double priceForSneakers = yearPaiment * 0.6;
double priceForOutfit = priceForSneakers - (priceForSneakers * 0.2);
double priceForBall = priceForOutfit / 4; 
double priceForAccessories = priceForBall / 5;

double finalPrice = yearPaiment + priceForSneakers + priceForOutfit + priceForBall + priceForAccessories;

Console.WriteLine(finalPrice);