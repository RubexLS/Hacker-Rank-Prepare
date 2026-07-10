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

    int count = newRanked.Count - 1;

    foreach(int score in player)
    {
        while (count >= 0 && score >= newRanked[count])
        {
            count--;
        }
        rankingNumber.Add(count+2);
    }
    return rankingNumber;
}