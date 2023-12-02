// See https://aka.ms/new-console-template for more information
var n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(Math.Pow(2, i));
    }
}
