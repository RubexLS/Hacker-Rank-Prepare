int q = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int qItr = 0; qItr < q; qItr++)
{
    int n = Convert.ToInt32(Console.ReadLine()!.Trim());

    List<List<int>> container = new List<List<int>>();

    for (int i = 0; i < n; i++)
    {
        container.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(containerTemp => Convert.ToInt32(containerTemp)).ToList());
    }

    string result = organizingContainers(container);

    Console.WriteLine(result);
}



static string organizingContainers(List<List<int>> container)
{
    List<long> rows = new List<long>();
    List<long> columns = new List<long>();

    for (int i = 0; i < container.Count(); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < container[i].Count(); j++)
        {
            sumRow += container[i][j];
        }
        rows.Add(sumRow);
    }

    for (int j = 0; j < container[0].Count(); j++)
    {
        int sumCol = 0;
        for (int i = 0; i < container.Count(); i++)
        {
            sumCol += container[i][j];
        }
        columns.Add(sumCol);
    }

    rows.Sort();
    columns.Sort();

    for(int i = 0; i < container.Count(); i++)
    {
        if(rows[i] != columns[i])
        {
            return "Impossible";
        }
    }

    return "Possible";
}