string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int n = Convert.ToInt32(firstMultipleInput[0]);
int k = Convert.ToInt32(firstMultipleInput[1]);

List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
 int result = workbook(n, k, arr);

        Console.WriteLine(result);




static int workbook(int n, int k, List<int> arr)
{
    int pageNumber = 0;
        int specialCount = 0;

        for (int i = 0; i < n; i++)
        {
            pageNumber++;
            int problemsInChapter = arr[i];

            for (int j = 1; j <= problemsInChapter; j++)
            {
                if (j > 1 && (j - 1) % k == 0)
                {
                    pageNumber++;
                }

                if (j == pageNumber)
                {
                    specialCount++;
                }
            }
        }

        return specialCount;
}