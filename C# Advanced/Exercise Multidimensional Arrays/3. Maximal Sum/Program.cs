

int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = numbers[col];
	}
}

int maxSum = int.MinValue;
int topLeftRow = 0;
int topLeftCol = 0;

for (int row = 0; row < rows - 2; row++)
{
	for (int col = 0; col < cols - 2; col++)
	{
		int sum = 0;

		sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
			   matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
			   matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

		if (sum > maxSum)
		{
			maxSum = sum;
			topLeftRow = row;
			topLeftCol = col;
		}
	}
}

Console.WriteLine($"Sum = {maxSum}");
for (int row = topLeftRow; row < topLeftRow + 3; row++)
{
	for (int col = topLeftCol; col < topLeftCol + 3; col++)
	{
		Console.Write($"{matrix[row, col]} ");
	}
	Console.WriteLine();
}