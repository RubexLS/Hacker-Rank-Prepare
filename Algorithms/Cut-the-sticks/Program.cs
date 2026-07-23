Console.WriteLine("Size of array.");
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> arr = new List<int>();

do
{
    Console.WriteLine($"{n} space-separated integers.");
    arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
}while(arr.Count != n);

List<int> result = cutTheSticks(arr);

Console.WriteLine("Number of sticks after each iteration");
Console.WriteLine(String.Join("\n", result));



static List<int> cutTheSticks(List<int> arr)
{
    List<int> size = new List<int>();
    size.Add(arr.Count);
    while(arr.Count > 0)
    {
        int littleStick = arr.Min();
        for(int i = 0; i < arr.Count; i++)
        {
            arr[i] -= littleStick;
        }
        arr.RemoveAll(n => n <= 0);
        if(arr.Count > 0)
            size.Add(arr.Count);
    }
    return size;
}