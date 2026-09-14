string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int p = Convert.ToInt32(firstMultipleInput[0]);
int d = Convert.ToInt32(firstMultipleInput[1]);
int m = Convert.ToInt32(firstMultipleInput[2]);
int s = Convert.ToInt32(firstMultipleInput[3]);

int answer = howManyGames(p, d, m, s);

Console.WriteLine(answer);



static int howManyGames(int p, int d, int m, int s)
{
    int count = 0;
    while (s >= p)
    {
        if (p > m){
            s -= p;
            p -= d;
            count++;
        }else{
            if(s >= m){
                p = m;
                s -= p;
                count++;
            }else{
                return count;
            }
        }
    }
    return count;
}