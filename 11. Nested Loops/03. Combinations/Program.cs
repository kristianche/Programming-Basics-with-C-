// See https://aka.ms/new-console-template for more information
var n = int.Parse(Console.ReadLine());
var combinations = 0;

for (var i = 0; i <= n; i++)
{
    for (var j = 0; j <= n; j++)
    {
        for (var k = 0;  k <= n; k++)
        {
            if (i + j + k == n)
            {
                combinations++;
            }
        }
    }
}

Console.WriteLine(combinations);
