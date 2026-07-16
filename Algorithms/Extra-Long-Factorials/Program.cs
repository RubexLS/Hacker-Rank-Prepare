using System.Numerics;

Console.WriteLine("Enter a single integer");
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

extraLongFactorials(n);



static void extraLongFactorials(int n)
{
    BigInteger factorial = (BigInteger)1;
    for(int i = 25; i > 0; i--)
        factorial *= (BigInteger)i;

    Console.WriteLine($"The factorial of {n}: {factorial}");
}