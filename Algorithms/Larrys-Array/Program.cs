int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    int n = Convert.ToInt32(Console.ReadLine()!.Trim());
    List<int> A = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();
    string result = larrysArray(A);

    Console.WriteLine(result);
}



static string larrysArray(List<int> A)
{
    int inversiones = 0;

    for (int i = 0; i < A.Count - 1; i++)
    {
        for (int j = i + 1; j < A.Count; j++)
        {
            if (A[i] > A[j])
                inversiones++;
        }
    }

    return (inversiones % 2 == 0) ? "YES" : "NO";
}