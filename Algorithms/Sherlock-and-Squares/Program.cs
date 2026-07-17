Console.WriteLine("Number of test cases.");
int q = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int qItr = 0; qItr < q; qItr++)
{
    Console.WriteLine("Contains two space-separated integers, a and b, the starting and ending integers in the ranges.");
    string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

    int a = Convert.ToInt32(firstMultipleInput[0]);
    int b = Convert.ToInt32(firstMultipleInput[1]);

    int result = squares(a, b);

    Console.WriteLine($"{result} square integers.");
}



static int squares(int a, int b)
{
    int square = 0;
    int i = 1;
    int count = 0;

    do
    {
        square += i;
        if(square >= a && square <= b)
            count++;

        i += 2;
    }while(square <= b);

    return count;
}