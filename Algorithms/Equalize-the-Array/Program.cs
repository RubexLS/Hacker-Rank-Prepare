int n = Convert.ToInt32(Console.ReadLine()!.Trim());

List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

int result = equalizeArray(arr);

Console.WriteLine(result);



static int equalizeArray(List<int> arr)
{
    int veryRepeat = arr.GroupBy(n => n).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
    List<int> arrayAux = arr.Where(n => n != veryRepeat).ToList();

    return arrayAux.Count();
}