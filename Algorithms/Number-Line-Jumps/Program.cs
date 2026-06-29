Console.WriteLine("Enter values in the formar (x1 v1 x2 v2)");
string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int x1 = Convert.ToInt32(firstMultipleInput[0]);
int v1 = Convert.ToInt32(firstMultipleInput[1]);
int x2 = Convert.ToInt32(firstMultipleInput[2]);
int v2 = Convert.ToInt32(firstMultipleInput[3]);

string result = kangaroo(x1, v1, x2, v2);

Console.WriteLine($"Do kangaroos meet in the same place?\n{result}");



static string kangaroo(int x1, int v1, int x2, int v2)
{
    //Si un canguro esta mas lejos y es maas rapido, el otro nunca lo alcanzara
    if(x1 > x2 && v1 >= v2)
        return "NO";

    if(x2 > x1 && v2 >= v1)
        return "NO";

    // la razon entre la posicion y las velocidades debe resultar en un modulo 0
    if((x1-x2)%(v2-v1) == 0)
        return "YES";
    
    return "NO";
}
