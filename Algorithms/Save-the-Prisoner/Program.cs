Console.WriteLine("Number of test cases.");
int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    Console.WriteLine("3 space-separated integers (n = number of prisoners, m = number of sweets & s = chair number to start)");
    string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

    int n = Convert.ToInt32(firstMultipleInput[0]);
    int m = Convert.ToInt32(firstMultipleInput[1]);
    int s = Convert.ToInt32(firstMultipleInput[2]);

    int result = saveThePrisoner(n, m, s);

    Console.WriteLine($"Warn prisone {result}");
}



static int saveThePrisoner(int n, int m, int s)
{
    int awful = m + s - 1;
    if(awful % n == 0)
        return n;
    else
        return awful % n;
}