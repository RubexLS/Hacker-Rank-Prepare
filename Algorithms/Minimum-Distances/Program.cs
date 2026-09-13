int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> a = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

int result = minimumDistances(a);

Console.WriteLine(result);



static int minimumDistances(List<int> a)
{
    List<int> withoutDuplicates = a.Distinct().ToList();

    if(a.Count() == withoutDuplicates.Count())
    {
        return -1;
    }

    int min = 0;
    foreach (int x in withoutDuplicates)
    {
        if(a.Count(n => n == x) == 2)
        {
            int firstIndex = a.IndexOf(x);
            int lastIndex = a.LastIndexOf(x);

            if(min == 0)
            {
                min = lastIndex - firstIndex;
            }
            else if((lastIndex - firstIndex) < min)
            {
                min = lastIndex - firstIndex;
            }
        }
    }
    return min;
}