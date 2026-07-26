string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int k = Convert.ToInt32(firstMultipleInput[1]);

List<int> s = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

int result = nonDivisibleSubset(k, s);

Console.WriteLine(result);



static int nonDivisibleSubset(int k, List<int> s)
{
    var remainders = new int[k];
    foreach (var e in s)
        remainders[e%k]++;

    var result = 0;
    if(remainders[0] > 0)
        result++;
    if(k%2 == 0)
    {
        if(remainders[k/2] > 0)
            result++;
        k--;
    }

    for(int i = 1; i <= k / 2; i++)
    {
        var h = Math.Max(remainders[i],remainders[remainders.Length-1]);
        result += h;
    }

    return result;
}