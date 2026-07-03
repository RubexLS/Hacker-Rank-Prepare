List<int> ar = new List<int>();

Console.WriteLine("Enter 2 space-separated integers");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int k = Convert.ToInt32(firstMultipleInput[1]);
do
{
    Console.WriteLine("Enter {n} elements space-separated integers");
    ar = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
}while(ar.Count != n);

int result = divisibleSumPairs(n, k, ar);

Console.WriteLine($"{result} valid pairs when k = {k}");




static int divisibleSumPairs(int n, int k, List<int> ar)
{
    int Count = 0;
    for (int i = 0; i < ar.Count - 1; i++)
        for (int j = i + 1; j < ar.Count; j++)
            if ((ar[i] + ar[j]) % k == 0)
                Count++;
        
    return Count;
}