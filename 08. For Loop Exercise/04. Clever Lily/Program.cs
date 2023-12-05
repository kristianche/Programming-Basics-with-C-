// See https://aka.ms/new-console-template for more information
var age = int.Parse(Console.ReadLine());
var dishwasher = double.Parse(Console.ReadLine());
var pricePerToy = int.Parse(Console.ReadLine());
var toyCount = 0;
var gotMoney = 0;
var money = 0;
var totalMoney = 0;

for (var i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        money += 10;
        totalMoney += money;
        gotMoney++;
    }
    else
    {
        toyCount++;
    }
}

var total = totalMoney + (pricePerToy * toyCount) - gotMoney;

if (total < dishwasher)
{
    Console.Write($"No! {(dishwasher - total):F2}");
}
else
{
    Console.WriteLine($"Yes! {(total - dishwasher):F2}");
}
