List<int> s = new List<int>();

Console.WriteLine("Number of squares in the chocolate bar.");
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

do
{
    Console.WriteLine("Enter the numbers on each of the squares of chocolate");
    s = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();
}while(n != s.Count);

Console.WriteLine("Ron's birth day and his birth month.");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int d = Convert.ToInt32(firstMultipleInput[0]);
int m = Convert.ToInt32(firstMultipleInput[1]);

int result = birthday(s, d, m);

Console.WriteLine($"{result} ways satisfies this constraint");



static int birthday(List<int> s, int d, int m)
{
    int segments = 0;
    for(int i = 0; i <= s.Count - m; i++)
    {
        int sum = 0;
        for(int j = i; j < i + m; j++)
        {
            sum += s[j];
        }
        if(sum == d)
            segments++;
    }
    return segments;
}