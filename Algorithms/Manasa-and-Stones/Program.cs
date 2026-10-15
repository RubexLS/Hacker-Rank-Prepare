int T = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int TItr = 0; TItr < T; TItr++)
{
    int n = Convert.ToInt32(Console.ReadLine()!.Trim());
    int a = Convert.ToInt32(Console.ReadLine()!.Trim());
    int b = Convert.ToInt32(Console.ReadLine()!.Trim());

    List<int> result = stones(n, a, b);

    Console.WriteLine(String.Join(" ", result));
}


static List<int> stones(int n, int  a, int  b)
{
    List<int> resultados = new List<int>();
    int pasos = n - 1;

    if (a == b)
    {
        resultados.Add(pasos * a);
        return resultados;
    }

    int menor = Math.Min(a, b);
    int mayor = Math.Max(a, b);

    for (int i = 0; i <= pasos; i++)
    {
        int valorFinal = (pasos - i) * menor + (i * mayor);
        resultados.Add(valorFinal);
    }

    return resultados;
}