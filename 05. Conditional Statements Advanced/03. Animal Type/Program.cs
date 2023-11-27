// See https://aka.ms/new-console-template for more information
var animal = Console.ReadLine();

switch (animal)
{
    case "dog":
        Console.WriteLine("mammal");
        break;

    case "crocodile":
    case "tortoise":
    case "snake":
        Console.WriteLine("reptile");
        break;

    default:
        Console.WriteLine("unknown");
        break;
}
