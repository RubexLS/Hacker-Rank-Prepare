string s = Console.ReadLine()!;

string result = encryption(s);

Console.WriteLine(result);



static string encryption(string s)
{
    double raiz = Math.Sqrt(s.Length);
    int size = 0;
    
    if (raiz % 1 == 0)
    {
        size = (int)raiz;
    }else{
        size = (int)raiz + 1;
    }

    string textEncrypted = "";

    for(int i = 0; i < size; i++)
    {
        string text = "";
        for (int j = i; j<s.Length; j+= size)
        {
            text += s[j];
        }
        textEncrypted += text;
        if(i < size-1)
            textEncrypted += " ";
    }
    return textEncrypted;
}