Console.WriteLine("eNTER 3 space-separated integers, n (number of elements), k (rotation count) and q (number of queries).");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int k = Convert.ToInt32(firstMultipleInput[1]);
int q = Convert.ToInt32(firstMultipleInput[2]);

Console.WriteLine($"Enter {n} array elements");
List<int> a = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

List<int> queries = new List<int>();

for (int i = 0; i < q; i++)
{
    int queriesItem = Convert.ToInt32(Console.ReadLine()!.Trim());
    queries.Add(queriesItem);
}

List<int> result = circularArrayRotation(a, k, queries);

Console.WriteLine(String.Join("\n", result));



static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
{
    int n = a.Count;
    int rotation = k % n;
    List<int> result = new List<int>();

    foreach (int q in queries)
    {
        int originIndex = (q - rotation + n) % n;
        result.Add(a[originIndex]);
    }
    return result;
}