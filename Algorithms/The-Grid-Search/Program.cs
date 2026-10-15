int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');
    int R = Convert.ToInt32(firstMultipleInput[0]);
    int C = Convert.ToInt32(firstMultipleInput[1]);
    List<string> G = new List<string>();

    for (int i = 0; i < R; i++)
    {
        string GItem = Console.ReadLine()!;
        G.Add(GItem);
    }

    string[] secondMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');
    int r = Convert.ToInt32(secondMultipleInput[0]);
    int c = Convert.ToInt32(secondMultipleInput[1]);
    List<string> P = new List<string>();

    for (int i = 0; i < r; i++)
    {
        string PItem = Console.ReadLine()!;
        P.Add(PItem);
    }

    string result = gridSearch(G, P);

    Console.WriteLine(result);
}



static string gridSearch(List<string> G, List<string> P)
{
    int R = G.Count;
    int C = G[0].Length;
    int r = P.Count;
    int c = P[0].Length;

    for (int i = 0; i <= R - r; i++)
    {
        for (int j = 0; j <= C - c; j++)
        {
            if (G[i].Substring(j, c) == P[0])
            {
                bool encontrado = true;
                for (int k = 1; k < r; k++)
                {
                    if (G[i + k].Substring(j, c) != P[k])
                    {
                        encontrado = false;
                        break;
                    }
                }

                if (encontrado)
                    return "YES";
                }
            }
        }

    return "NO";
}
