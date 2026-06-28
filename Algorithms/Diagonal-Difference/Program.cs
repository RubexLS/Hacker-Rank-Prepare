Console.WriteLine("Enter size array nxn");
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<List<int>> arr = new List<List<int>>();

Console.WriteLine("enter array:");

// validacion de la matriz
for (int i = 0; i < n; i++)
{
    arr.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

int result = diagonalDifference(arr, n);

Console.WriteLine($"Diagonal Difference: {result}");


static int diagonalDifference(List<List<int>> arr, int n)
{
    int sumPrimaryDiagonal = 0;
    int sumSecundaryDiagonal = 0;
    int j = 1;
    for(int i = 0; i < n; i++)
    {
        sumPrimaryDiagonal += arr[i][i];
        sumSecundaryDiagonal += arr[i][n-j];
        j++;
    }

    return Math.Abs(sumPrimaryDiagonal - sumSecundaryDiagonal);
}