string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int m = Convert.ToInt32(firstMultipleInput[1]);

List<string> grid = new List<string>();

for (int i = 0; i < n; i++)
{
    string gridItem = Console.ReadLine()!;
    grid.Add(gridItem);
}

int result = twoPluses(grid);

Console.WriteLine(result);



static int twoPluses(List<string> grid)
{
    int rows = grid.Count;
    int cols = grid[0].Length;

    char[][] matrix = new char[rows][];
    for (int i = 0; i < rows; i++)
    {
        matrix[i] = grid[i].ToCharArray();
    }

    int maxProduct = 0;

    for (int r1 = 0; r1 < rows; r1++)
    {
        for (int c1 = 0; c1 < cols; c1++)
        {
            int step1 = 0;
            while (r1 - step1 >= 0 && r1 + step1 < rows && 
                c1 - step1 >= 0 && c1 + step1 < cols &&
                matrix[r1 - step1][c1] == 'G' && matrix[r1 + step1][c1] == 'G' &&
                matrix[r1][c1 - step1] == 'G' && matrix[r1][c1 + step1] == 'G')
            {
                matrix[r1 - step1][c1] = 'X';
                matrix[r1 + step1][c1] = 'X';
                matrix[r1][c1 - step1] = 'X';
                matrix[r1][c1 + step1] = 'X';

                int area1 = 1 + 4 * step1;

                for (int r2 = 0; r2 < rows; r2++)
                {
                    for (int c2 = 0; c2 < cols; c2++)
                    {
                        int step2 = 0;
                        while (r2 - step2 >= 0 && r2 + step2 < rows && 
                            c2 - step2 >= 0 && c2 + step2 < cols &&
                            matrix[r2 - step2][c2] == 'G' && matrix[r2 + step2][c2] == 'G' &&
                            matrix[r2][c2 - step2] == 'G' && matrix[r2][c2 + step2] == 'G')
                        {
                            int area2 = 1 + 4 * step2;
                            maxProduct = Math.Max(maxProduct, area1 * area2);
                            step2++;
                        }
                    }
                }

                step1++;
            }

            for (int s = 0; s < step1; s++)
            {
                matrix[r1 - s][c1] = 'G';
                matrix[r1 + s][c1] = 'G';
                matrix[r1][c1 - s] = 'G';
                matrix[r1][c1 + s] = 'G';
            }
        }
    }

    return maxProduct;
}