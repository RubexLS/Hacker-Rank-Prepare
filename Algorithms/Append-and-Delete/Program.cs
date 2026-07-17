Console.WriteLine("The initial string.");
string s = Console.ReadLine()!;

Console.WriteLine("The desired string.");
string t = Console.ReadLine()!;

Console.WriteLine("the exact number of operations that must be performed ");
int k = Convert.ToInt32(Console.ReadLine()!.Trim());

string result = appendAndDelete(s, t, k);

Console.WriteLine(result);



static string appendAndDelete(string s, string t, int k)
{
    int similar = 0;
    if (s == t)
        return "Yes";
    else
    {
        int count = 0;
        if(s.Length <= t.Length)
            count = s.Length;
        else
            count = t.Length;

        char[] arrayS = s.ToCharArray();
        char[] arrayT = t.ToCharArray();

        for(int i = 0; i < count; i++)
        {
            if(arrayS[i] != arrayT[i])
            {
                similar = i;
                break;
            }
            else if(i == count - 1)
                similar = i;
        }

        int operations = 0;
        if(similar == 0 && k >= (s.Length + t.Length))
            return "Yes";
        else if(similar == 0 && k < (s.Length + t.Length))
            return "No";
        else if(s.Length != t.Length)
            operations = s.Length + t.Length - (2*similar);
        else if(s.Length == similar)
            operations = t.Length - similar;
        else if(t.Length == similar)
            operations = s.Length - similar;

        if(operations == k)
            return "Yes";
        else
            return "No";
    }
}