Console.WriteLine("Date which the book was returned.");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int d1 = Convert.ToInt32(firstMultipleInput[0]);
int m1 = Convert.ToInt32(firstMultipleInput[1]);
int y1 = Convert.ToInt32(firstMultipleInput[2]);

Console.WriteLine("Date which the book was due to be returned.");
string[] secondMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int d2 = Convert.ToInt32(secondMultipleInput[0]);
int m2 = Convert.ToInt32(secondMultipleInput[1]);
int y2 = Convert.ToInt32(secondMultipleInput[2]);

int result = libraryFine(d1, m1, y1, d2, m2, y2);

Console.WriteLine($"There is a fixed fine of {result}");



static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
{
    if(y1 != y2 && y1 > y2)
        return 10000;
    else if(y2 > y1)
        return 0;
    else
    {
        if(m1 != m2 && m1 > m2)
            return (m1 - m2) * 500;
        else if(m2 > m1)
            return 0;
        else
        {
            if(d1 != d2 && d1 > d2)
                return (d1 - d2) * 15;
            else
                return 0;
        }
    }
}