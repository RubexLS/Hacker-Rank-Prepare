//numero de elementos de la matriz
Console.WriteLine("Enter number elements:");
int arCount = Convert.ToInt32(Console.ReadLine()!.Trim());

List<long> ar = new List<long>();
bool verify = false;

Console.WriteLine("Enter long elements:");

//validacion del numero de elementos ingresado
do
{
    ar = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
    if(ar.Count != arCount)
        Console.WriteLine($"Enter {arCount} elements:");

    else
        verify = true;

}while(verify == false);

long result = aVeryBigSum(ar);

Console.WriteLine($"The integer sum of the elements is {result}");

static long aVeryBigSum(List<long> ar)
{
    return ar.Sum();
}