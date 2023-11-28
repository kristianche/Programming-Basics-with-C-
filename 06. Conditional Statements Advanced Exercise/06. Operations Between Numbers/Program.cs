// See https://aka.ms/new-console-template for more information
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char operations = char.Parse(Console.ReadLine());

if (operations == '+' || operations == '-' || operations == '*')
{
    int result = 0;
    string evenOrOdd = "even";

    if (operations == '+')
    {
        result = num1 + num2;
    }
    else if (operations == '-')
    {
        result = num1 - num2;
    }
    else
    {
        result = num1 * num2;
    }
    if (result % 2 != 0)
    {
        evenOrOdd = "odd";
    }
    Console.WriteLine($"{num1} {operations} {num2} = {result} - {evenOrOdd}");
}
else
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else if (operations == '/')
    {
        Console.WriteLine($"{num1} / {num2} = {((double)num1 / num2):f2}");
    }
    else
    {
        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
    }
}
