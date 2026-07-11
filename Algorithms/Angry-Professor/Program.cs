Console.WriteLine("Number of test cases.");
int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    Console.WriteLine("Number of students and the cancellation threshold.");
    string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

    int n = Convert.ToInt32(firstMultipleInput[0]);
    int k = Convert.ToInt32(firstMultipleInput[1]);

    Console.WriteLine($"Enter {n} space-separated integers that describe the arrival times for each student.");
    List<int> a = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

    string result = angryProfessor(k, a);

    Console.WriteLine(result);
}



static string angryProfessor(int k, List<int> a)
{
    var group = a.GroupBy(n => n  <= 0);

    List<int> early = group.FirstOrDefault(g => g.Key == true)?.ToList() ?? new();

    if (early.Count >= k)
        return "NO";
    else
        return "YES";
}