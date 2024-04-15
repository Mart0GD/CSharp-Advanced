

int size = int.Parse(Console.ReadLine());

int[][] jagged = new int[size][];

for (int i = 0; i < size; i++)
{
    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

    jagged[i] = array;
}

AnalyzeMatrix(size, jagged);


string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens.First();

    int row = int.Parse(tokens[1]);
    int col = int.Parse(tokens[2]);
    int value = int.Parse(tokens[3]);

    if (ValidateIndexes(row, col, jagged))
    {
        jagged[row][col] = action == "Add" ? jagged[row][col] + value : jagged[row][col] - value;
    }
}

for (int row = 0; row < jagged.Length; row++)
{

    for (int col = 0; col < jagged[row].Length; col++)
    {
        Console.Write($"{jagged[row][col]} ");
    }
    Console.WriteLine();
}






bool ValidateIndexes(int row, int col, int[][] jagged)
{
    if (row >=0 && row < jagged.Length)
    {
        if (col >= 0 && col < jagged[row].Length)
        {
            return true;
        }
    }

    return false;

}

static void AnalyzeMatrix(int size, int[][] jagged)
{
    for (int row = 0; row < size; row++)
    {
        if (row == size - 1) break;

        bool equal = false;
        if (jagged[row].Length == jagged[row + 1].Length)
        {
            equal = true;
        }

        for (int col = 0; col < jagged[row].Length; col++)
        {
            if (equal)
            {
                jagged[row][col] *= 2;
                jagged[row + 1][col] *= 2;
            }
            else
            {
                jagged[row][col] /= 2;
            }

        }

        if (!equal)
        {
            for (int x = 0; x < jagged[row + 1].Length; x++)
            {
                jagged[row + 1][x] /= 2;
            }
        }
    }
}