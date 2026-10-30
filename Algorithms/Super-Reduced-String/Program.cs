string s = Console.ReadLine()!;

string result = superReducedString(s);

Console.WriteLine(result);



static string superReducedString(string s)
{
    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        if (stack.Count > 0 && stack.Peek() == c)
            stack.Pop();
        else
            stack.Push(c);
    }

    if (stack.Count == 0)
        return "Empty String";

    char[] resultArray = stack.ToArray();
    Array.Reverse(resultArray);
    
    return new string(resultArray);
}