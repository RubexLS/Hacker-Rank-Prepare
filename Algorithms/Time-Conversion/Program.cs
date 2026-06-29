
string s = Console.ReadLine()!;

string result = timeConversion(s);

Console.WriteLine(result);



static string timeConversion(string s)
{
    List<string> hour = new List<string>();
    hour = s.Split(':').ToList();
    int newHour = int.Parse(hour[0]);

    if(hour[2].Substring(2,2) == "PM")
    {
        newHour += 12;
        if(newHour == 24)
            hour[0] = "12";

        else
            hour[0] = newHour.ToString();
    }
    else
    {
        if(newHour == 12)
            hour[0] = "00";
    }
        
    hour[2] = hour[2].Substring(0,2);

    return $"{hour[0]}:{hour[1]}:{hour[2]}";
}