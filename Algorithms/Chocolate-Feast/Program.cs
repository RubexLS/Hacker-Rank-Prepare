int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
    string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

    int n = Convert.ToInt32(firstMultipleInput[0]);
    int c = Convert.ToInt32(firstMultipleInput[1]);
    int m = Convert.ToInt32(firstMultipleInput[2]);

    int result = chocolateFeast(n, c, m);

    Console.WriteLine(result);
}



static int chocolateFeast(int n, int c, int m)
{
    int chocolatesComidos = n / c;
    int envolturas = chocolatesComidos;
        
    while (envolturas >= m)
    {
        int nuevosChocolates = envolturas / m;
        chocolatesComidos += nuevosChocolates;
        envolturas = (envolturas % m) + nuevosChocolates;
    }
        
    return chocolatesComidos;
}