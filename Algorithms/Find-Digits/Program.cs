Console.WriteLine("Number of test cases.");
int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    Console.WriteLine("Enter integer:");
    int n = Convert.ToInt32(Console.ReadLine()!.Trim());
    int result = findDigits(n);

    Console.WriteLine($"The remainder is {result}");
}



static int findDigits(int n)
{
    int count = 0;
    List<int> divisor = new List<int>();

    foreach (char x in n.ToString())
        divisor.Add(x - '0');

    foreach (int i in divisor)
    {
        if(i == 0)
            continue;
        else
        {    
            if(n % i == 0)
                count++;
        }
    }

    return count;
}