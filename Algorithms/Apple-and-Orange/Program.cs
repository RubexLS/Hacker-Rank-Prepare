Console.WriteLine("enter space-separated\nstart and end point");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int s = Convert.ToInt32(firstMultipleInput[0]);
int t = Convert.ToInt32(firstMultipleInput[1]);

Console.WriteLine("Apple tree and orange tree location:");
string[] secondMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int a = Convert.ToInt32(secondMultipleInput[0]);
int b = Convert.ToInt32(secondMultipleInput[1]);

Console.WriteLine("How many apples and oranges will fall?");
string[] thirdMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int m = Convert.ToInt32(thirdMultipleInput[0]);
int n = Convert.ToInt32(thirdMultipleInput[1]);

bool verifyA = false;
bool verifyB = false;
List<int> apples = new List<int>();
List<int> oranges = new List<int>();

Console.WriteLine("where will apples fall?");
do
{
    apples = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();
    if(apples.Count != m)
        Console.WriteLine("Try again");
    else
        verifyA = true;

}while(verifyA == false);

Console.WriteLine("where will oranges fall?");
do
{
    oranges = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();
    if(oranges.Count != n)
        Console.WriteLine("Try again");
    else
        verifyB = true;

}while(verifyB == false);

countApplesAndOranges(s, t, a, b, apples, oranges);



static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{
    List<int> applesLand = new List<int>();
    List<int> orangesLand = new List<int>();
    int redRegionApples = 0;
    int redRegionOranges = 0;

    foreach (int x in apples)
        applesLand.Add(x + a);
    
    foreach (int x in oranges)
        orangesLand.Add(x + b);
    
    foreach(int x in applesLand)
    {
        if(x >= s && x <= t)
            redRegionApples++;

    }

    foreach(int x in orangesLand)
    {
        if(x >= s && x <= t)
            redRegionOranges++;

    }

    Console.WriteLine($"Only {redRegionApples} orange(s) falls within the region.\nOnly {redRegionOranges} apple(s) falls within the region.");
}