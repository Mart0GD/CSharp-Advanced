

using System.Net.Security;

int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
	int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int col = 0; col < size; col++)
	{
		matrix[row,col] = numbers[col];
	}
}

string[] cordinatesInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

List<Tuple<int, int>> cordinates = new();
foreach (var item in cordinatesInput)
{
	int[] pair = item.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

	cordinates.Add(new Tuple<int, int>(pair[0], pair[1]));
}

foreach (var bomb in cordinates)
{
    int bombRow = bomb.Item1;
    int bombCol = bomb.Item2;

    if (matrix[bombRow,bombCol] <= 0)
    {
        break;
    }

    int damage = matrix[bombRow, bombCol];

    Explode(matrix, bombRow, bombCol, damage);

    matrix[bombRow, bombCol] = 0;
}


int aliveCells = 0;
int sum = 0;

for (int row = 0; row < size; row++)
{

    for (int col = 0; col < size; col++)
    {
        aliveCells += matrix[row, col] > 0 ? 1 : 0;
        sum += matrix[row, col] > 0 ? matrix[row,col] : 0;
    }
}

Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");

Print(size, matrix);





static bool ValidateIndexs(int row, int col, int[,] matrix)
{ 
	return row >= 0 && row < matrix.GetLength(0) &&
		   col >= 0 && col < matrix.GetLength(1);
}

static void Explode(int[,] matrix, int bombRow, int bombCol, int damage)
{
    if (ValidateIndexs(bombRow + 1, bombCol, matrix))
    {
        matrix[bombRow + 1, bombCol] -= matrix[bombRow + 1, bombCol] <= 0 ? 0 : damage;
    }
    if (ValidateIndexs(bombRow + 1, bombCol + 1, matrix))
    {
        matrix[bombRow + 1, bombCol + 1] -= matrix[bombRow + 1, bombCol + 1] <= 0 ? 0 : damage;
    }
    if (ValidateIndexs(bombRow + 1, bombCol - 1, matrix))
    {
        matrix[bombRow + 1, bombCol - 1] -= matrix[bombRow + 1, bombCol - 1] <= 0 ? 0 : damage;
    }
    if (ValidateIndexs(bombRow, bombCol + 1, matrix))
    {
        matrix[bombRow, bombCol + 1] -= matrix[bombRow, bombCol + 1] <= 0 ? 0 : damage;
    }
    if (ValidateIndexs(bombRow, bombCol - 1, matrix))
    {
        matrix[bombRow, bombCol - 1] -= matrix[bombRow, bombCol - 1] <= 0 ? 0 : damage;
    }
    if (ValidateIndexs(bombRow - 1, bombCol, matrix))
    {
        matrix[bombRow - 1, bombCol] -= matrix[bombRow - 1, bombCol] <= 0 ? 0 : damage;
    }
    if (ValidateIndexs(bombRow - 1, bombCol + 1, matrix))
    {
        matrix[bombRow - 1, bombCol + 1] -= matrix[bombRow - 1, bombCol + 1] <= 0 ? 0 : damage;
    }
    if (ValidateIndexs(bombRow - 1, bombCol - 1, matrix))
    {
        matrix[bombRow - 1, bombCol - 1] -= matrix[bombRow - 1, bombCol - 1] <= 0 ? 0 : damage;
    }

}

static void Print(int size, int[,] matrix)
{
    for (int row = 0; row < size; row++)
    {

        for (int col = 0; col < size; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}