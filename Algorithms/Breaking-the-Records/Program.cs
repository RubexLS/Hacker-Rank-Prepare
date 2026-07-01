List<int> scores;

Console.WriteLine("Enter the number of games:");
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

do
{
    Console.WriteLine($"Enter {n} scores for each game separated by spaces:");
    scores = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();
}while(scores.Count != n);

List<int> result = breakingRecords(scores);

//Console.WriteLine(String.Join(" ", result));
Console.WriteLine($"She broke her best record {result[0]} time(s) and her worst record {result[1]} time(s)");



static List<int> breakingRecords(List<int> scores)
{
    int minScore = scores[0];
    int maxScore = scores[0];
    int breakMinScore = 0;
    int breakMaxScore = 0;
    List<int> records = new List<int>();

    for(int i = 1; i < scores.Count; i++)
    {
        if(minScore > scores[i])
        {
            minScore = scores[i];
            breakMinScore++;
        }

        if(maxScore < scores[i])
        {
            maxScore = scores[i];
            breakMaxScore++;
        }
    }
    records.Add(breakMaxScore);
    records.Add(breakMinScore);

    return records;
}