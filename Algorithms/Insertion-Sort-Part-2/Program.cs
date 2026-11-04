int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

insertionSort2(n, arr);



static void insertionSort2(int n, List<int> arr)
{
    for (int i = 1; i < n; i++)
    {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;

        Console.WriteLine(string.Join(" ", arr));
    }
}