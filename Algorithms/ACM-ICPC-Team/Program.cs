string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);

int m = Convert.ToInt32(firstMultipleInput[1]);

List<string> topic = new List<string>();

for (int i = 0; i < n; i++)
{
    string topicItem = Console.ReadLine()!;
    topic.Add(topicItem);
}

List<int> result = acmTeam(topic, m);

Console.WriteLine(String.Join("\n", result));



static List<int> acmTeam(List<string> topic, int m)
{
    int maxTop = 0;
    int maxTeam = 0;
    
    for(int i = 0; i<topic.Count()-1; i++)
    {
        for(int j = i+1; j<topic.Count(); j++)
        {
            int currentTop = 0;
            for(int k = 0; k<m; k++)
            {
                if (topic[i][k] == '1' || topic[j][k] == '1')
                {
                    currentTop++;
                }
            }
            if (currentTop > maxTop)
            {
                maxTop = currentTop;
                maxTeam = 1;
            }
            else if (currentTop == maxTop && maxTop > 0)
            {
                maxTeam++;
            }
        }
    }
    return new List<int>() {maxTop, maxTeam};
}