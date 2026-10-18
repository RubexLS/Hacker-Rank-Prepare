int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

    int n = Convert.ToInt32(firstMultipleInput[0]);
    int k = Convert.ToInt32(firstMultipleInput[1]);

    List<int> result = absolutePermutation(n, k);

    Console.WriteLine(String.Join(" ", result));
}



static List<int> absolutePermutation(int n, int k)
{
    List<int> result = new List<int>();

    if (k == 0)
    {
        for (int i = 1; i <= n; i++)
        {
            result.Add(i);
        }
        return result;
    }

    if (n % (2 * k) != 0)
        return new List<int> { -1 };

    int addSwitch = k;
    for (int i = 1; i <= n; i++)
    {
        result.Add(i + addSwitch);

        if (i % k == 0)
            addSwitch = -addSwitch;
    }

    return result;
}