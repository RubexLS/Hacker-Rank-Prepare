string s = Console.ReadLine()!;
int result = marsExploration(s);

Console.WriteLine(result);



static int marsExploration(string s)
{
    int alteredCount = 0;
    
    for (int i = 0; i < s.Length; i++)
    {
        int positionInPattern = i % 3;
        
        if (positionInPattern == 1)
        {
            if (s[i] != 'O') 
                alteredCount++;
        }
        else
        {
            if (s[i] != 'S') 
                alteredCount++;
        }
    }
    
    return alteredCount;
}