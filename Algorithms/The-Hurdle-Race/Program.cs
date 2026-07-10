Console.WriteLine("Number of hurdles 'n' and the maximum height 'k' the character can jump naturally. (n k)");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int k = Convert.ToInt32(firstMultipleInput[1]);

List<int> height = new List<int>();
do
{
    Console.WriteLine($"{n} space-separated integers");
    height = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();
}while(height.Count != n);

int result = hurdleRace(k, height);
Console.WriteLine($"The character needs to drink {result} doses.");



static int hurdleRace(int k, List<int> height)
{
    int maxHardle = height.Max();

    if(maxHardle == k)
        return 0;
    else
        return (maxHardle - k);
}