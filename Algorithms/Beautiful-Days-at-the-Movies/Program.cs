Console.WriteLine("Entre three space-separated integers describing the respective values of i, j, and k.");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int i = Convert.ToInt32(firstMultipleInput[0]);
int j = Convert.ToInt32(firstMultipleInput[1]);
int k = Convert.ToInt32(firstMultipleInput[2]);

int result = beautifulDays(i, j, k);

Console.WriteLine($"Only {result} days in this interval are beautiful.");



static int beautifulDays(int i, int j, int k)
{
    List<string> days = new List<string>();
    List<string> daysReverse = new List<string>();

    for(int range = i; range <= j; range++)
        days.Add(range.ToString());

    char[] number;
    foreach(string x in days)
    {
        number = x.ToCharArray();
        Array.Reverse(number);
        daysReverse.Add(new string(number));
    }

    int count = 0;
    for (int a = 0; a < days.Count; a++)
    {
        int x = Convert.ToInt32(days[a]);
        int y = Convert.ToInt32(daysReverse[a]);
        if((Math.Abs(x-y)) % k == 0)
            count++;
    }
    return count;

}