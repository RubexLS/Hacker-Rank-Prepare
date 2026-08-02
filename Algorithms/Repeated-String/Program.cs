string s = Console.ReadLine()!;

long n = Convert.ToInt64(Console.ReadLine()!.Trim());

long result = repeatedString(s, n);

Console.WriteLine(result);



static long repeatedString(string s, long n)
{
    if (s == "a")
        return n;
    else
    {
        int size = s.Length;
        int amount = s.Count(c => c == 'a');

        if (n % size == 0)
        {
            return (n/size) * amount;
        }
        else if (n % size != 0)
        {
            int remainder = 0;
            for (int i = 0; i < n%size; i++)
            {
                if (s[i] == 'a')
                    remainder++;
            }
            return (n/size) * amount + remainder;
        }
        else
            return 0;
    }
}