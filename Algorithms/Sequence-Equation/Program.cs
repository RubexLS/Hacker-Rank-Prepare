int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> p = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(pTemp => Convert.ToInt32(pTemp)).ToList();

List<int> result = permutationEquation(p);

Console.WriteLine(String.Join("\n", result));



static List<int> permutationEquation(List<int> p)
{
    List<int> pInitial = new List<int>();
    List<int> pFinal = new List<int>();

    for (int i = 1; i <= p.Count; i++)
    {
        for(int j = 0; j < p.Count; j++)
        {
            if(i == p[j])
                pInitial.Add(j);
        }
    }

    for (int i = 0; i < p.Count; i++)
    {
        for(int j = 0; j < p.Count; j++)
        {
            if(pInitial[i]+1 == p[j])
                pFinal.Add(j+1);
        }
    }
    return pFinal;
}