using System.ComponentModel.Design.Serialization;

List<List<int>> s = new List<List<int>>();

Console.WriteLine("Give a 3 x 3 matrix (s) of integers in the inclusive range [1,9].");
for (int i = 0; i < 3; i++)
    s.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());

int result = formingMagicSquare(s);

Console.WriteLine($"Matrix \"s\" becomes a magic square at the minimum possible cost: {result}");



static int formingMagicSquare(List<List<int>> s)
{
    int[,,] magicSquare = new int[8,3,3]
    {
    {{2,7,6},{9,5,1},{4,3,8}},
    {{2,9,4},{7,5,3},{6,1,8}},
    {{6,1,8},{7,5,3},{2,9,4}},
    {{6,7,2},{1,5,9},{8,3,4}},
    {{8,1,6},{3,5,7},{4,9,2}},
    {{8,3,4},{1,5,9},{6,7,2}},
    {{4,9,2},{3,5,7},{8,1,6}},
    {{4,3,8},{9,5,1},{2,7,6}}
    };

    int minCost = 0;
    for (int m = 0; m < 8; m++)
    {
        int cost = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if(magicSquare[m, i ,j] != s[i][j])
                    cost += Math.Abs(magicSquare[m, i ,j] - s[i][j]);
            }
        }
        if(cost == 0)
            return 0;

        if(minCost == 0)
            minCost = cost;
        else
            if(minCost > cost)
                minCost = cost;
    }
    return minCost;
}

