int N = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> B = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

string result = fairRations(B);

Console.WriteLine(result);



static string fairRations (List<int> B)
{
    int count = 0;
    for (int i = 0; i < B.Count - 1; i++) 
    {
        if (B[i] % 2 == 1) 
        {
            B[i]++;
            B[i + 1]++;
            count += 2;
        }
    }
    
    return B[^1] % 2 == 1 ? "NO" : count.ToString();
}