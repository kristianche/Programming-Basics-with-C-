// See https://aka.ms/new-console-template for more information
int countChicken = int.Parse(Console.ReadLine());
int countFish = int.Parse(Console.ReadLine());
int countVegan = int.Parse(Console.ReadLine());

double priceChicken = countChicken * 10.35;
double priceFish = countFish * 12.40;
double priceVegan = countVegan * 8.15;
double priceMenus = priceChicken + priceFish + priceVegan;
double dessertPrice = 0.2 * priceMenus;

double totalPrice = priceMenus + dessertPrice + 2.5;

Console.WriteLine(totalPrice);