string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int k = Convert.ToInt32(firstMultipleInput[1]);

string[] secondMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int r_q = Convert.ToInt32(secondMultipleInput[0]);
int c_q = Convert.ToInt32(secondMultipleInput[1]);

List<List<int>> obstacles = new List<List<int>>();

for (int i = 0; i < k; i++)
{
    obstacles.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
}

int result = queensAttack(n, k, r_q, c_q, obstacles);

Console.WriteLine(result);



static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
{
    int count = 0;
    var obstaculosSet = obstacles.Select(obs => (obs[0], obs[1])).ToHashSet();
    //norte
    int r = r_q; int c = c_q;
    if(r > 1)
    {
        while (r > 1)
        {
            r--;
            if(obstaculosSet.Contains((r, c)))
                break;
            else
                count++;
        }
    }
    //sur
    r = r_q; c = c_q;
    if(r < n)
    {
        while (r < n)
        {
            r++;
            if(obstaculosSet.Contains((r, c)))
                break;
            else
                count++;
        }
    }
    //oeste
    r = r_q; c = c_q;
    if(c > 1)
    {
        while (c > 1)
        {
            c--;
            if(obstaculosSet.Contains((r, c)))
                break;
            else
                count++;
        }
    }
    //este
    r = r_q; c = c_q;
    if(c < n)
    {
        while (c < n)
        {
            c++;
            if(obstaculosSet.Contains((r, c)))
                break;
            else
                count++;
        }
    }
    //no
    r = r_q; c = c_q;
    if(c > 1 && r > 1)
    {
        while (c > 1 && r > 1)
        {
            c--;
            r--;
            if(obstaculosSet.Contains((r, c)))
                break;
            else
                count++;
        }
    }
    //so
    r = r_q; c = c_q;
    if(c > 1 && r < n)
    {
        while (c > 1 && r < n)
        {
            c--;
            r++;
            if(obstaculosSet.Contains((r, c)))
                break;
            else
                count++;
        }
    }
    //ne
    r = r_q; c = c_q;
    if(c < n && r > 1)
    {
        while (c < n && r > 1)
        {
            c++;
            r--;
            if(obstaculosSet.Contains((r, c)))
                break;
            else
                count++;
        }
    }
    //se
    r = r_q; c = c_q;
    if(c < n && r < n)
    {
        while (c < n && r < n)
        {
            c++;
            r++;
            if(obstaculosSet.Contains((r, c)))
                break;
            else
                count++;
        }
    }
    return count;
}