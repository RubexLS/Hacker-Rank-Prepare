int h = Convert.ToInt32(Console.ReadLine()!.Trim());
int m = Convert.ToInt32(Console.ReadLine()!.Trim());

string result = timeInWords(h, m);

Console.WriteLine(result);



static string timeInWords(int h, int m)
{
    Dictionary<int, string> numbersToWords = new Dictionary<int, string>
    {
            {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"},
            {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"},
            {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"},
            {15, "quarter"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"},
            {19, "nineteen"}, {20, "twenty"}, {21, "twenty one"}, {22, "twenty two"},
            {23, "twenty three"}, {24, "twenty four"}, {25, "twenty five"},
            {26, "twenty six"}, {27, "twenty seven"}, {28, "twenty eight"},
            {29, "twenty nine"}
    };

    if (m == 0)
    {
        return $"{numbersToWords[h]} o' clock";
    }

    if (m == 30)
    {
        return $"half past {numbersToWords[h]}";
    }

    if (m == 15)
    {
        return $"quarter past {numbersToWords[h]}";
    }

    if (m == 45)
    {
        int nextHour = h == 12 ? 1 : h + 1;
        return $"quarter to {numbersToWords[nextHour]}";
    }

    if (m < 30)
    {
        string minuteWord = m == 1 ? "minute" : "minutes";
        return $"{numbersToWords[m]} {minuteWord} past {numbersToWords[h]}";
    }
    else 
    {
        int minutesLeft = 60 - m;
        int nextHour = h == 12 ? 1 : h + 1;
        string minuteWord = minutesLeft == 1 ? "minute" : "minutes";
        return $"{numbersToWords[minutesLeft]} {minuteWord} to {numbersToWords[nextHour]}";
    }
}