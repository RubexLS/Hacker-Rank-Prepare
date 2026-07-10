Console.WriteLine("Number of test cases. ");
int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    Console.WriteLine("Number of cycles for that test case.");
    int n = Convert.ToInt32(Console.ReadLine()!.Trim());
    int result = utopianTree(n);

    Console.WriteLine($"it's height is {result} meters.");
}



static int utopianTree(int n)
{
    int height = 0;
    for (int i = 0; i <= n; i++)
    {
        if(i % 2 == 0)
            height++;
        else
            height*=2;
    }
    return height;
}