//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int n = 21;
int count = 0;


if (n <=1)
{
    Console.WriteLine("ne sade ne murekkeb");
}
else if (n == 2)
{
    Console.WriteLine("sadedir");
}
for (int i = 1; i <= n; i++)
{
    if(n%i == 0)
    {
        count++;
    }
    if (count > 2)
    {
        Console.WriteLine("Murekkebdir");
        break;
    }
}

