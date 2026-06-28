//size base and height
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

staircase(n);


static void staircase(int n)
{
    for(int i = 0; i < n; i++)
    {
        int j = n - 1 - i;
        string spaceBar = "";
        string stair = "";
        while(j > 0)
        {
            spaceBar += " ";
            j--;
        }

        if(n > 0)
        {
            int k = 0;
            stair += "#";
            do
            {
                if(i > k)
                {
                    stair += "#";
                    k++;
                }
            }while(k != i);
        }

        Console.WriteLine(spaceBar + stair);
    }
}
