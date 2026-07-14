Console.WriteLine("Enter 2 space-separated integers. (n: number of clouds & k: jump distance)");
string[] nk = Console.ReadLine()!.Split(' ');

int n = Convert.ToInt32(nk[0]);
int k = Convert.ToInt32(nk[1]);

Console.WriteLine($"{n} contains space-separated integers (0 and 1)");
int[] c = Array.ConvertAll(Console.ReadLine()!.Split(' '), cTemp => Convert.ToInt32(cTemp));

int result = jumpingOnClouds(c, k);
Console.WriteLine($"The final energy level is {result}");



static int jumpingOnClouds(int[] c, int k)
{
    int energy = 100;
    int[] clouds = c;
    while(clouds.Length % k != 0)
        clouds = clouds.Concat(c).ToArray();

    for (int i = k; i < clouds.Length - k + 1; i+= k)
    {
        if (clouds[i] == 1)
            energy -= 3;
        else
            energy -= 1;
    }

    if (clouds[0]==1)
        energy -= 3;
    else
        energy -= 1;

    return energy;
}