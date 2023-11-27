// See https://aka.ms/new-console-template for more information
var product = Console.ReadLine();

switch (product)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
    case "grapes":
        Console.WriteLine("fruit");
        break;

    case "tomato":
    case "cucumber":
    case "pepper":
    case "carrot":
        Console.WriteLine("vegetable");
        break;

    default:
        Console.WriteLine("unknown");
        break;
}