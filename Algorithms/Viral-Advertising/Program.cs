Console.WriteLine("The day number.");
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

int result = viralAdvertising(n);

Console.WriteLine($"The cumulative likes at that day: {result}");



static int viralAdvertising(int n)
{
    int peopleLiked = 5/2;
    int cumulative = peopleLiked;
    int i = 1;
    if(n > 1)
    {
        do
        {
            i++;
            int share = peopleLiked*3;
            peopleLiked = share/2;
            cumulative += peopleLiked;
        }while(i != n);
        return cumulative;
    }
    else
        return cumulative;
}