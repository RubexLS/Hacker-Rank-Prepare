int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<string> unsorted = new List<string>();

for (int i = 0; i < n; i++)
{
    string unsortedItem = Console.ReadLine()!;
    unsorted.Add(unsortedItem);
}

List<string> result = bigSorting(unsorted);
Console.WriteLine(String.Join("\n", result));



static List<string> bigSorting(List<string> unsorted)
{
    unsorted.Sort((x, y) => {
        if (x.Length != y.Length) 
            return x.Length.CompareTo(y.Length);

        return string.CompareOrdinal(x, y);
    });

    return unsorted;
}