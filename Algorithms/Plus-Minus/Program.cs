Console.WriteLine("Nomber elements array:");

int n = Convert.ToInt32(Console.ReadLine()!.Trim());

bool verify = false;
List<int> arr = new List<int>();

do
{
    arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    if(n != arr.Count)
        Console.WriteLine($"Enter {n} elements");

    else
        verify = true;

}while(verify == false);

plusMinus(arr);


static void plusMinus(List<int> arr)
{
    int countPositive = 0;
    int countNegative = 0;
    int countZeroes = 0;
    foreach(int x in arr)
    {
        if(x > 0)
            countPositive++;

        else if(x < 0)
            countNegative++;

        else
            countZeroes++; 
    }

    Console.WriteLine("The proportions of occurrence are");
    Console.WriteLine($"positive: {((float)countPositive/arr.Count):F6}\nnegative: {((float)countNegative/arr.Count):F6}\nzeros: {((float)countZeroes/arr.Count):F6}");
}
