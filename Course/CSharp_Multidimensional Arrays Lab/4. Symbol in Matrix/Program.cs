
int squareMatrixSize = int.Parse(Console.ReadLine());

char[][] matrix = new char[squareMatrixSize][];

for (int row = 0;row < squareMatrixSize; row++)
{
    string symbols = Console.ReadLine();

    matrix[row] = symbols.ToCharArray();
}

char symbolToSearch = char.Parse(Console.ReadLine());
bool found = false;
int symbolRow = 0;
int symbolCol = 0;

for (int row = 0; row < matrix.Length; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        if (matrix[row][col] == symbolToSearch)
        {
            found = true;
            symbolRow = row;
            symbolCol = col;
        }
    }

    if (found)
    {
        Console.WriteLine($"({symbolRow}, {symbolCol})");
        return;
    }
}

Console.WriteLine($"{symbolToSearch} does not occur in the matrix");