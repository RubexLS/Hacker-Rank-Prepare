Console.WriteLine("Enter number candles:");
int candlesCount = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> candles = new List<int>();
bool verify = false;

Console.WriteLine($"Enter {candlesCount} elements:");

do
{
    candles = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
    if(candlesCount != candles.Count)
        Console.WriteLine($"Enter {candlesCount} elements:");

    else
        verify = true;

}while(verify == false);

int result = birthdayCakeCandles(candles);

Console.WriteLine(result);


static int birthdayCakeCandles(List<int> candles)
{
    int tall = candles.Max();
    int i = 0;
    foreach(int x in candles)
    {
        if(tall == x)
        {
            i++;
        }
    }

    return i;
}