Console.WriteLine("Enter three space-separated integers b, n and m.");
string[] bnm = Console.ReadLine()!.Split(' ');

int b = Convert.ToInt32(bnm[0]);
int n = Convert.ToInt32(bnm[1]);
int m = Convert.ToInt32(bnm[2]);

int[] keyboards, drives;

do
{
    Console.WriteLine("Keyboard prices:");
    keyboards = Array.ConvertAll(Console.ReadLine()!.Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));
}while(n != keyboards.Length);

do
{
    Console.WriteLine("Drive prices");
    drives = Array.ConvertAll(Console.ReadLine()!.Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));
}while(m != drives.Length);

int moneySpent = getMoneySpent(keyboards, drives, b);

Console.WriteLine($"The maximum that can be spent: {moneySpent}");



static int getMoneySpent(int[] keyboards, int[] drives, int b)
{
    int priceExpensive = 0;
    foreach(int i in keyboards)
    {
        foreach (int j in drives)
        {
            if(i + j > priceExpensive && i + j <= b)
                priceExpensive = i + j;
            
        }
    }
    if(priceExpensive > 0)
        return priceExpensive;
    else
        return -1;
}