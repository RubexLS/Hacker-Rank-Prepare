List<long> arr = new List<long>();
bool verify = false;

do
{
    arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(long.Parse).ToList();
    if(arr.Count != 5)
        Console.WriteLine("Enter 5 elements");
    
    else
        verify = true;
}while(verify == false);


miniMaxSum(arr);


static void miniMaxSum(List<long> arr)
{
    long mini = arr.Sum() - arr[0];
    long max = arr.Sum() - arr[0];
    for (int i = 1; i < arr.Count; i++)
    {
        if(max < arr.Sum()-arr[i])
            max = arr.Sum()-arr[i];

        else if(mini > arr.Sum()-arr[i])
            mini = arr.Sum()-arr[i];
    }

    Console.WriteLine($"The minimum sum: {mini}\nThe maximum sum: {max}\n4 of 5 elements.");
}