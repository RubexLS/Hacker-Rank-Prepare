//creacion de txt para equipo local

string? outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");

if (string.IsNullOrEmpty(outputPath))
{
    outputPath = "output_local.txt";
}

using TextWriter textWriter = new StreamWriter(outputPath, true);

//------------------------------------------------------------------------------

List<int> a = new List<int>();
List<int> b = new List<int>();
bool validateData = false;

Console.WriteLine("Ingrese las calificaciones de Alice y Bob respectivamente en el formato [a b c]");

// do while para verificar que el usuario ingrese las 3 calificaciones necesarias
do
{
    a = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
    b = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

    if(a.Count != 3 || b.Count != 3)
        Console.WriteLine("Ingrese nuevamente las calificaciones:");
    
    else
        validateData = true;

}while(validateData == false);

List<int> result = compareTriplets(a, b).ToList();

textWriter.WriteLine(result);

Console.WriteLine($"Resultado guardado con éxito: {result[0]}, {result[1]}");


// metodo para la asignacion de puntos en funcion a la comparacion de calificaciones de alice y bob
static List<int> compareTriplets(List<int> a, List<int> b)
{
    int alicePoints = 0;
    int bobPoints = 0;

    for(int i = 0; i < a.Count; i++)
    {
        if(a[i] > b[i])
            alicePoints++;

        else if(a[i] < b[i])
            bobPoints++;
    }
    
    return [alicePoints, bobPoints];
}