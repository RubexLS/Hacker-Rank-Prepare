Console.WriteLine("Enter the size of the first array and the second array separated by a space:");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

List<int> arr = new List<int>();
List<int> brr = new List<int>();

int n = Convert.ToInt32(firstMultipleInput[0]);
int m = Convert.ToInt32(firstMultipleInput[1]);

do
{
    Console.WriteLine($"Enter {n} integers for the first array separated by spaces:");
    arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
}while(arr.Count != n);

do
{
    Console.WriteLine($"Enter {m} integers for the second array separated by spaces:");
    brr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();
}while(brr.Count != m);

int total = getTotalX(arr, brr);

Console.WriteLine($"There are {total} numbers between the arrays.");


static int getTotalX(List<int> arr, List<int> brr)
{
    List<int>   factors = new List<int>();
    for (int i = arr.Min(); i <= brr.Min(); i++)
    {
        int count = 0;
        foreach(int x in arr)
        {
            if(i % x == 0)
            {
                count++;
                if(count == arr.Count)
                {
                    factors.Add(i);
                }
            }
        }
    }

    int factorsTotal= 0;
    foreach(int i in factors)
    {
        int countTotal= 0;
        foreach(int x in brr)
        {
            if (x % i == 0)
            {
                countTotal++;
                if(countTotal == brr.Count)
                    factorsTotal++;
            }
        }
    }
    return factorsTotal;
}
