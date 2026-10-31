int V = Convert.ToInt32(Console.ReadLine()!.Trim());
int n = Convert.ToInt32(Console.ReadLine()!.Trim());
List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int result = introTutorial(V, arr);

Console.WriteLine(result);



static int introTutorial(int V, List<int> arr)
{
    int izquierda = 0;
    int derecha = arr.Count - 1;

    while (izquierda <= derecha)
    {
        int medio = izquierda + (derecha - izquierda) / 2;

        if (arr[medio] == V)
            return medio;
        
        if (arr[medio] < V)
            izquierda = medio + 1;
        else
            derecha = medio - 1;
    }

    return -1; 
}