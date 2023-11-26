// See https://aka.ms/new-console-template for more information
var excursionCost = double.Parse(Console.ReadLine());
var puzzlesCount = int.Parse(Console.ReadLine());
var speakingDollsCount = int.Parse(Console.ReadLine());
var tedyBearsCount = int.Parse(Console.ReadLine());
var minionsCount = int.Parse(Console.ReadLine());
var trucksCount = int.Parse(Console.ReadLine());

var puzzlesPrice = puzzlesCount * 2.60;
var speakingDollsPrice = speakingDollsCount * 3;
var tedyBearsPrice = tedyBearsCount * 4.10;
var minionsPrice = minionsCount * 8.20;
var trucksPrice = trucksCount * 2;

var totalPrice = puzzlesPrice + speakingDollsPrice + tedyBearsPrice + minionsPrice + trucksPrice;
var totalToysCount = puzzlesCount + speakingDollsCount + tedyBearsCount + minionsCount + trucksCount;

if (totalToysCount >= 50)
{
    totalPrice -= 0.25 * totalPrice;
}

totalPrice -= 0.1 * totalPrice;

if (totalPrice < excursionCost)
{
    Console.WriteLine($"Not enough money! {(excursionCost - totalPrice):F2} lv needed."); 
} else
{
    Console.WriteLine($"Yes! {(totalPrice - excursionCost):F2} lv left.");
}
