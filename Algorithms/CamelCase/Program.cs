string s = Console.ReadLine()!;

int result = camelcase(s);

Console.WriteLine(result);



static int camelcase(string s)
{
    if (string.IsNullOrEmpty(s)) return 0;

    int contadorPalabras = 1;

    foreach (char c in s)
    {
        if (char.IsUpper(c))
            contadorPalabras++;
    }

    return contadorPalabras;
}