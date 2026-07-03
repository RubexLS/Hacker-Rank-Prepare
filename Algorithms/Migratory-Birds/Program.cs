List<int> arr = new List<int>();

Console.WriteLine("Enter the amount of bird sightings.");
int arrCount = Convert.ToInt32(Console.ReadLine()!.Trim());

do
{
    Console.WriteLine($"Enter {arrCount} records.");
    arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
}while(arr.Count != arrCount);

int result = migratoryBirds(arr);

Console.WriteLine($"Type {result}");



static int migratoryBirds(List<int> arr)
{
    List<int> newArr = new List<int>();
    List<int> frequency = new List<int>();
    newArr = arr.Distinct().ToList();

    int maxRepeated = 0;
    foreach(int i in newArr)
    {
        int count = 0;
        foreach (int j in arr)
        {
            if(i == j)
                count++;
            
        }
        if(count > maxRepeated)
            maxRepeated = count;
    }

    foreach(int i in newArr)
    {
        int count = 0;
        foreach (int j in arr)
        {
            if(i == j)
                count++;
            
        }
        if(count == maxRepeated)
            frequency.Add(i);
    }

    return frequency.Min();
}