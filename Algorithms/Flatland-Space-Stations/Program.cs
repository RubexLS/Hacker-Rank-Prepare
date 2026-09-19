string[] nm = Console.ReadLine()!.Split(' ');

int n = Convert.ToInt32(nm[0]);
int m = Convert.ToInt32(nm[1]);

int[] c = Array.ConvertAll(Console.ReadLine()!.Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
int result = flatlandSpaceStations(n, c);

Console.WriteLine(result);



static int flatlandSpaceStations(int n, int[]c)
{
    Array.Sort(c);
        
    int maxDist = c[0];
        
    for (int i = 1; i < c.Length; i++)
    {
        int currentDist = (c[i] - c[i - 1]) / 2;
        if (currentDist > maxDist)
            maxDist = currentDist;
    }
    
    int lastDist = (n - 1) - c[c.Length - 1];
    if (lastDist > maxDist)
        maxDist = lastDist;
    
    return maxDist;
}