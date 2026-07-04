List<int> bill = new List<int>();

Console.WriteLine("Enter the number of items 'n' ordered and the 0 based index 'k' of the item that Anna did not eat.");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int k = Convert.ToInt32(firstMultipleInput[1]);

do
{
    Console.WriteLine("Enter the cost of each item ordered");
    bill = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();
}while(bill.Count != n);

Console.WriteLine("Enter the amount of money that Anna contributed to the bill");
int b = Convert.ToInt32(Console.ReadLine()!.Trim());

bonAppetit(bill, k, b);



static void bonAppetit(List<int> bill, int k,  int b)
{
    bill.RemoveAt(k);

    int anna = bill.Sum() / 2;

    if(anna == b)
        Console.WriteLine("Bon Appetit");

    else
        Console.WriteLine($"Brian owes {b - anna} to Anna.");
}
