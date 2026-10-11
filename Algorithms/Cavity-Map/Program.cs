int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<string> grid = new List<string>();

for (int i = 0; i < n; i++)
{
    string gridItem = Console.ReadLine()!;
    grid.Add(gridItem);
}

List<string> result = cavityMap(grid);

Console.WriteLine(String.Join("\n", result));



static List<string> cavityMap(List<string> grid)
{
    int n = grid.Count;
    char[][] resultGrid = new char[n][];
    for (int i = 0; i < n; i++)
    {
        resultGrid[i] = grid[i].ToCharArray();
    }

    for (int i = 1; i < n - 1; i++)
    {
        for (int j = 1; j < n - 1; j++)
        {
            char current = grid[i][j];
            if (current > grid[i - 1][j] && 
                current > grid[i + 1][j] && 
                current > grid[i][j - 1] && 
                current > grid[i][j + 1])
            {
                resultGrid[i][j] = 'X';
            }
        }
    }

    List<string> finalResult = new List<string>();
    for (int i = 0; i < n; i++)
    {
        finalResult.Add(new string(resultGrid[i]));
    }

    return finalResult;
}