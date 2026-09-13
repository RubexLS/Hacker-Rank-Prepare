string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int d = Convert.ToInt32(firstMultipleInput[1]);

List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int result = beautifulTriplets(d, arr);

Console.WriteLine(result);



static int beautifulTriplets(int d, List<int> arr)
{
    int count = 0;
    for (int i = arr.Count()-1 ; i>0 ; i--)
    {
        if (arr.Contains(arr[i]-d) && arr.Contains(arr[i]-2*d))
        {
            count++;
            if (arr.Count(n => n == arr[i]-2*d) > 1)
            {
                count += (arr.Count(n => n == arr[i]-2*d)) - 1;
            }
        }
    }
    return count;
}