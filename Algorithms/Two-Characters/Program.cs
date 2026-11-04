int l = Convert.ToInt32(Console.ReadLine()!.Trim());
string s = Console.ReadLine()!;

int result = alternate(s);

Console.WriteLine(result);



static int alternate(string s)
{
    char[] uniqueChars = s.Distinct().ToArray();
    int maxLength = 0;

    for (int i = 0; i < uniqueChars.Length; i++)
    {
        for (int j = i + 1; j < uniqueChars.Length; j++)
        {
            char c1 = uniqueChars[i];
            char c2 = uniqueChars[j];
            int currentLength = GetAlternatingLength(s, c1, c2);
            
            if (currentLength > maxLength)
                maxLength = currentLength;
        }
    }

    return maxLength;
}

static int GetAlternatingLength(string s, char c1, char c2)
{
    int length = 0;
    char lastChar = '\0';

    foreach (char c in s)
    {
        if (c == c1 || c == c2)
        {
            if (c == lastChar)
                return 0; 

            lastChar = c;
            length++;
        }
    }

    return length >= 2 ? length : 0;
}