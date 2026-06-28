string? outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");

if (string.IsNullOrEmpty(outputPath))
{
    outputPath = "output_local.txt";
}

using TextWriter textWriter = new StreamWriter(outputPath, true);

bool verify = false;
List<int> ar = new List<int>();

Console.WriteLine("Ingrese el numero de elementos:");
int arCount = int.Parse(Console.ReadLine()!.Trim());

Console.WriteLine("Inserte los elementos:");
do
{
    ar = Console.ReadLine()!.TrimEnd().Split(' ').Select(int.Parse).ToList();
    if(ar.Count != arCount)
        Console.WriteLine($"ingrese {arCount} elementos:");

    else
        verify = true;

}while(verify == false);

int result = simpleArraySum(ar);

textWriter.WriteLine(result);

Console.WriteLine($"Resultado guardado con éxito: {result}");



static int simpleArraySum(List<int> ar)
{
    return ar.Sum();
}