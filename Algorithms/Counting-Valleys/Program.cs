Console.WriteLine("Number of steps on the hike.");
int steps = Convert.ToInt32(Console.ReadLine()!.Trim());

Console.WriteLine("describe the path.");
string path = Console.ReadLine()!;

int result = countingValleys(steps, path);

Console.WriteLine($"The hiker enters and leaves {result} valley.");



static int countingValleys(int steps, string path)
{
    int hike = 0;
    int count = 0;
    foreach (char x in path)
    {
        if(hike == 0 && x == 'D')
        {
            hike -= 1;
            count++;
        }
        else if(x == 'D')
            hike -= 1;
        
        else if(x == 'U')
            hike += 1;
    }
    return count;
}