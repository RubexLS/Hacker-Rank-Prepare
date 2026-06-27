Console.WriteLine("Insert the first value:");
int val1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert the second value:");
int val2 = Convert.ToInt32(Console.ReadLine());
int sum = solveMeFirst(val1,val2);
Console.WriteLine(sum);

static int solveMeFirst(int a, int b)
{
    return a + b;
}