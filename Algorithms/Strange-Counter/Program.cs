long t = Convert.ToInt64(Console.ReadLine()!.Trim());

long result = strangeCounter(t);

Console.WriteLine(result);



static long strangeCounter(long t)
{
    long t_inicio = 1;
    long valor_inicial = 3;

    while (t >= t_inicio + valor_inicial)
    {
        t_inicio += valor_inicial;
        valor_inicial *= 2;
    }

    return valor_inicial - (t - t_inicio);
}