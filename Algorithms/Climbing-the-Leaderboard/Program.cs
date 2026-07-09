Console.WriteLine("Number of players on the leaderboard.");
int rankedCount = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> ranked = new List<int>();
do
{
    Console.WriteLine($"Leaderboard scores in decreasing order. (contains {rankedCount} space-separated integers)");
    ranked = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();
}while(rankedCount != ranked.Count);

Console.WriteLine("Number games the player plays.");
int playerCount = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> player = new List<int>();
do
{
    Console.WriteLine($"Game scores. (contains {playerCount} space-separated integers)");
    player = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();
}while(playerCount != player.Count);

List<int> result = climbingLeaderboard(ranked, player);
Console.WriteLine(String.Join("\n", result));



static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
{
    List<int> rankingNumber = new List<int>();
    List<int> newRanked = new List<int>();

    newRanked = ranked.Distinct().ToList();


    for (int i = 0; i < player.Count; i++)
    {
        for(int j = 0; j < newRanked.Count; j++)
        {
            if(player[i] >= newRanked[0] && j == 0)
            {
                rankingNumber.Add(1);
                break;
            }
            else if(j != 0)
            {
                if (player[i] < newRanked[j-1] && player[i] >= newRanked[j])
                {
                    rankingNumber.Add(j+1);
                    break;
                }
                else if (player[i] < newRanked[newRanked.Count-1])
                {
                    rankingNumber.Add(newRanked.Count+1);
                    break;
                }
            }
        }
    }
    return rankingNumber;
}