int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> c = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

int result = jumpingOnClouds(c);

Console.WriteLine(result);



static int jumpingOnClouds(List<int> c)
{
    int jumps = 0;
    for(int i = 0; i < c.Count - 1; i++)
    {
        if(i == c.Count - 2)
        {
            i++;
            jumps++;
        }
        else if (c[i+1] == 1)
        {
            i++;
            jumps++;
        }
        else if(c[i+1] == 0 && c[i+2] == 0)
        {
            i++;
            jumps++;
        }else if(c[i+1] == 0 && c[i+2] == 1)
        {
            jumps++;
        }
    }
    return jumps;
}