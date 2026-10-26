int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

almostSorted(arr);



static void almostSorted(List<int> arr)
{
    int n = arr.Count;

    List<int> sortedArr = new List<int>(arr);
    sortedArr.Sort();

    List<int> diffIndices = new List<int>();
    for (int i = 0; i < n; i++)
    {
        if (arr[i] != sortedArr[i])
            diffIndices.Add(i);
    }

    if (diffIndices.Count == 0)
    {
        Console.WriteLine("yes");
        return;
    }

    int first = diffIndices[0];
    int last = diffIndices[diffIndices.Count - 1];

    if (diffIndices.Count == 2)
    {
        Console.WriteLine("yes");
        Console.WriteLine($"swap {first + 1} {last + 1}");
        return;
    }

    bool canReverse = true;
    for (int i = 0; i < diffIndices.Count; i++)
    {
        if (arr[first + i] != sortedArr[last - i])
        {
            canReverse = false;
            break;
        }
    }

    if (canReverse)
    {
        Console.WriteLine("yes");
        Console.WriteLine($"reverse {first + 1} {last + 1}");
    }
    else
    {
        Console.WriteLine("no");
    }
}