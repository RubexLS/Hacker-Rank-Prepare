string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

int m = Convert.ToInt32(firstMultipleInput[0]);
int n = Convert.ToInt32(firstMultipleInput[1]);
int r = Convert.ToInt32(firstMultipleInput[2]);
List<List<int>> matrix = new List<List<int>>();

for (int i = 0; i < m; i++)
    matrix.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());

matrixRotation(matrix, r);



static void matrixRotation(List<List<int>> matrix, int r)
{
    int m = matrix.Count;
    int n = matrix[0].Count;
    int numLayers = Math.Min(m, n) / 2;

    for (int layer = 0; layer < numLayers; layer++) 
    {
        List<int> layerElements = new List<int>();
        
        for (int j = layer; j < n - layer; j++) 
            layerElements.Add(matrix[layer][j]);

        for (int i = layer + 1; i < m - layer; i++) 
            layerElements.Add(matrix[i][n - 1 - layer]);

        for (int j = n - 2 - layer; j >= layer; j--) 
            layerElements.Add(matrix[m - 1 - layer][j]);

        for (int i = m - 2 - layer; i > layer; i--) 
            layerElements.Add(matrix[i][layer]);

        int len = layerElements.Count;
        int actualRotation = r % len; 
        int index = actualRotation;

        for (int j = layer; j < n - layer; j++) {
            matrix[layer][j] = layerElements[index];
            index = (index + 1) % len;
        }

        for (int i = layer + 1; i < m - layer; i++) {
            matrix[i][n - 1 - layer] = layerElements[index];
            index = (index + 1) % len;
        }

        for (int j = n - 2 - layer; j >= layer; j--) {
            matrix[m - 1 - layer][j] = layerElements[index];
            index = (index + 1) % len;
        }

        for (int i = m - 2 - layer; i > layer; i--) {
            matrix[i][layer] = layerElements[index];
            index = (index + 1) % len;
        }
    }

    for (int i = 0; i < m; i++) 
        Console.WriteLine(string.Join(" ", matrix[i]));
}