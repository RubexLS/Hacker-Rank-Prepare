int g = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int gItr = 0; gItr < g; gItr++)
{
    int n = Convert.ToInt32(Console.ReadLine()!.Trim());
    string b = Console.ReadLine()!;
    string result = happyLadybugs(b);

    Console.WriteLine(result);
}



static string happyLadybugs(string b)
{
    Dictionary<char, int> counts = new Dictionary<char, int>();
    foreach (char c in b)
    {
        if (counts.ContainsKey(c))
            counts[c]++;
        else
            counts[c] = 1;
    }

    foreach (var pair in counts)
    {
        if (pair.Key != '_' && pair.Value == 1)
            return "NO";
    }

    if (!counts.ContainsKey('_'))
    {
        for (int i = 0; i < b.Length; i++)
        {
            bool hasLeftNeighbor = (i > 0 && b[i] == b[i - 1]);
            bool hasRightNeighbor = (i < b.Length - 1 && b[i] == b[i + 1]);

            if (!hasLeftNeighbor && !hasRightNeighbor)
                return "NO";
        }
    }

    return "YES";
}