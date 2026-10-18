string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int r = Convert.ToInt32(firstMultipleInput[0]);
int c = Convert.ToInt32(firstMultipleInput[1]);
int n = Convert.ToInt32(firstMultipleInput[2]);

List<string> grid = new List<string>();

for (int i = 0; i < r; i++)
{
    string gridItem = Console.ReadLine()!;
    grid.Add(gridItem);
}

List<string> result = bomberMan(n, grid);

Console.WriteLine(String.Join("\n", result));



static List<string> bomberMan(int n, List<string> grid)
{
    if (n <= 1)
        return grid;

    int rows = grid.Count;
    int cols = grid[0].Length;

    if (n % 2 == 0)
    {
        List<string> fullGrid = new List<string>();
        string fullRow = new string('O', cols);
        for (int i = 0; i < rows; i++)
        {
            fullGrid.Add(fullRow);
        }
        return fullGrid;
    }

    List<string> state3 = Detonate(grid, rows, cols);

    if (n % 4 == 3)
        return state3;

    if (n % 4 == 1)
        return Detonate(state3, rows, cols);

    return grid;
}

static List<string> Detonate(List<string> currentGrid, int rows, int cols)
{
    char[][] nextGrid = new char[rows][];
    for (int i = 0; i < rows; i++)
    {
        nextGrid[i] = new string('O', cols).ToCharArray();
    }

    int[] dr = { -1, 1, 0, 0 };
    int[] dc = { 0, 0, -1, 1 };

    for (int r = 0; r < rows; r++)
    {
        for (int c = 0; c < cols; c++)
        {
            if (currentGrid[r][c] == 'O')
            {
                nextGrid[r][c] = '.';
                for (int d = 0; d < 4; d++)
                {
                    int nr = r + dr[d];
                    int nc = c + dc[d];
                    if (nr >= 0 && nr < rows && nc >= 0 && nc < cols)
                        nextGrid[nr][nc] = '.';
                }
            }
        }
    }

    List<string> result = new List<string>();
    for (int i = 0; i < rows; i++)
    {
        result.Add(new string(nextGrid[i]));
    }
    return result;
}