List<int> ar = new List<int>();

Console.WriteLine("Enter the number of socks in the pile");
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

do
{
    Console.WriteLine("Enter the sock colors ({n})");
    ar = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
}while(n != ar.Count);


int result = sockMerchant(n, ar);

Console.WriteLine(result);



static int sockMerchant(int n, List<int> ar)
{
    List<int> color = new List<int>();
    color = ar.Distinct().ToList();
    
    int sumPairs = 0;

    foreach(int c in color)
    {
        int count = 0;
        foreach (int a in ar)
        {
            if(c == a)
                count++;
        }
        if(count % 2 == 0)
            sumPairs += count / 2;
        else
            sumPairs += (count - 1) / 2;
    }

    return sumPairs;
}