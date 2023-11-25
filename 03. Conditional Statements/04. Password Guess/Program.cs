// See https://aka.ms/new-console-template for more information
var password = Console.ReadLine();
var correctPassword = "s3cr3t!P@ssw0rd";

if (password == correctPassword)
{
    Console.WriteLine("Welcome");
} else
{
    Console.WriteLine("Wrong password!");
}
