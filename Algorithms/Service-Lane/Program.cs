string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int t = Convert.ToInt32(firstMultipleInput[1]);

List<int> width = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(widthTemp => Convert.ToInt32(widthTemp)).ToList();

List<List<int>> cases = new List<List<int>>();

for (int i = 0; i < t; i++)
{
    cases.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(casesTemp => Convert.ToInt32(casesTemp)).ToList());
}

List<int> result = serviceLane(n, cases, width);

Console.WriteLine(String.Join("\n", result));



List<int> serviceLane(int n, List<List<int>> cases, List<int> width)
{
    List<int> result = new List<int>();
        
    foreach (var c in cases) {
        int entry = c[0];
        int exit = c[1];
        
        int minWidth = width.GetRange(entry, exit - entry + 1).Min();
        result.Add(minWidth);
    }
    
    return result;
}