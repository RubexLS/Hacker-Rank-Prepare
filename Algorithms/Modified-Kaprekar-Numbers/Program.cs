int p = Convert.ToInt32(Console.ReadLine()!.Trim());

int q = Convert.ToInt32(Console.ReadLine()!.Trim());

kaprekarNumbers(p, q);



static void kaprekarNumbers(int p, int q)
{
    List<int> kaprekarNumbers = new List<int>();

    for (int i = p; i <= q; i++)
    {
        long square = (long)i * (long)i;
        string squareStr = square.ToString();
        int d = i.ToString().Length;

        string rightPart = "";
        string leftPart = "";
        
        if (squareStr.Length >= d) {
            rightPart = squareStr.Substring(squareStr.Length - d);
        }
        else
        {
            rightPart = squareStr;
        }

        if (squareStr.Length > d) {
            leftPart = squareStr.Substring(0, squareStr.Length - d);
        }
        else
        {
            leftPart = "0";
        }

        int leftNum = int.Parse(leftPart);
        int rightNum = int.Parse(rightPart);

        if (leftNum + rightNum == i)
        {
            kaprekarNumbers.Add(i);
        }
    }

    if (kaprekarNumbers.Count > 0)
    {
        Console.WriteLine(string.Join(" ", kaprekarNumbers));
    }
    else
    {
        Console.WriteLine("INVALID RANGE");
    }
}