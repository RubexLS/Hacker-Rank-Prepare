int n = Convert.ToInt32(Console.ReadLine()!.Trim());
List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

insertionSort1(n, arr);



static void insertionSort1(int n, List<int> arr)
{
    int target = arr[n - 1];
    int i = n - 2;

    while (i >= 0 && arr[i] > target)
    {
        arr[i + 1] = arr[i];
        Console.WriteLine(string.Join(" ", arr));
        i--;
    }

    arr[i + 1] = target;
    Console.WriteLine(string.Join(" ", arr));
}