string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int H = Convert.ToInt32(firstMultipleInput[0]);
int W = Convert.ToInt32(firstMultipleInput[1]);

List<List<int>> A = new List<List<int>>();

for (int i = 0; i < H; i++)
{
    A.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList());
}

int result = surfaceArea(A);

Console.WriteLine(result);



static int surfaceArea(List<List<int>> A)
{
    int H = A.Count;
    int W = A[0].Count;
    int totalArea = 0;
    int[] dRow = { -1, 1, 0, 0 };
    int[] dCol = { 0, 0, -1, 1 };

    for (int i = 0; i < H; i++)
    {
        for (int j = 0; j < W; j++)
        {
            int currentHeight = A[i][j];

            if (currentHeight > 0)
                totalArea += 2;

            for (int d = 0; d < 4; d++)
            {
                int neighborRow = i + dRow[d];
                int neighborCol = j + dCol[d];
                int neighborHeight = 0;

                if (neighborRow >= 0 && neighborRow < H && neighborCol >= 0 && neighborCol < W)
                    neighborHeight = A[neighborRow][neighborCol];

                if (currentHeight > neighborHeight)
                    totalArea += (currentHeight - neighborHeight);
            }
        }
    }

    return totalArea;
}