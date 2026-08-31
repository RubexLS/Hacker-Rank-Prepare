int T = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int TItr = 0; TItr < T; TItr++)
{
    string w = Console.ReadLine()!;

    string result = biggerIsGreater(w);

    Console.WriteLine(result);
}



static string biggerIsGreater(string w)
{
    char[] charArray = w.ToCharArray();
    int n = charArray.Length;
    
    int i = n - 2;
    while (i >= 0 && charArray[i] >= charArray[i + 1]) i--;

    if (i < 0) return "no answer";
    
    int j = n - 1;
    while (charArray[j] <= charArray[i]) j--;
    
    char temp = charArray[i];
    charArray[i] = charArray[j];
    charArray[j] = temp;
    
    int left = i + 1;
    int right = n - 1;
    while (left < right) 
    {
        char t = charArray[left];
        charArray[left] = charArray[right];
        charArray[right] = t;
        left++;
        right--;
    }
    
    return new string(charArray);
}