List<int> h = new List<int>();
do
{
    Console.WriteLine("Enter 26 space-separated integers describing the respective heights");
    h = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();
}while(h.Count != 26);

Console.WriteLine("Enter a single word");
string word = Console.ReadLine()!.ToLower();

int result = designerPdfViewer(h, word);
Console.WriteLine($"The selection area for this word is: {result}mm2");



static int designerPdfViewer(List<int> h, string word)
{
    string lowerLetter = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
    List<char> letter = new List<char>();
    letter = lowerLetter.Split(',').ToList().Select(hTemp => Convert.ToChar(hTemp)).ToList();

    int maxheight = 0;
    foreach(char l in word)
    {
        for (int i =0; i < h.Count; i++)
        {
            if(l == letter[i] && h[i]>maxheight)
                maxheight = h[i];
        }
    }
    return (maxheight * word.Length);
}   