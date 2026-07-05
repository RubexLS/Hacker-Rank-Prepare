Console.WriteLine("Enter the number of pages in the book");
int n = Convert.ToInt32(Console.ReadLine()!.Trim());

Console.WriteLine("Enter the page number to turn to ");
int p = Convert.ToInt32(Console.ReadLine()!.Trim());

int result = pageCount(n, p);

Console.WriteLine($"The minimum number of pages to turn: {result}");



static int pageCount(int n, int p)
{
    int desdeInicio = p / 2;
        
    int desdeFinal = (n / 2) - (p / 2);

    return Math.Min(desdeInicio, desdeFinal);
}