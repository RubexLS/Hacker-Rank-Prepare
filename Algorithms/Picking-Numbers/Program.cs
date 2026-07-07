int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> a = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

int result = pickingNumbers(a);

Console.WriteLine(result);



static int pickingNumbers(List<int> a)
{
    List<int> newA = new List<int>();
    newA = a.Distinct().ToList();

    int maxLength = 0;
    for(int i = 0; i < newA.Count - 1; i++)
    {
        for(int j = i + 1; j < newA.Count; j++)
        {
            if (Math.Abs(newA[i]-newA[j]) == 1)
            {
                int elementA = newA[i];
                int elementB = newA[j];
                int moauntA = a.Count(n => n == elementA);
                int moauntB = a.Count(n => n == elementB);
                if(moauntA + moauntB > maxLength)
                    maxLength = moauntA + moauntB;
            }
        }
    }
    return maxLength;
}
