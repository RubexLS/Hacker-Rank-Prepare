using System.Data.Common;

Console.WriteLine("Number of queries.");
int q = Convert.ToInt32(Console.ReadLine());

for (int qItr = 0; qItr < q; qItr++) {
    
    Console.WriteLine("Enter three space-separated integers describing the respective values of (cat A's location), (cat B's location), and (mouse C's location).");
    string[] xyz = Console.ReadLine()!.Split(' ');

    int x = Convert.ToInt32(xyz[0]);
    int y = Convert.ToInt32(xyz[1]);
    int z = Convert.ToInt32(xyz[2]);

    string result = catAndMouse(x, y, z);

    Console.WriteLine($"\n{result}");
}



static string catAndMouse(int x, int y, int z)
{
    if(Math.Abs(x-z) < Math.Abs(y-z))
        return "Cat A";
    else if(Math.Abs(x-z) > Math.Abs(y-z))
        return "Cat B";
    else
        return "Mouse C";
}