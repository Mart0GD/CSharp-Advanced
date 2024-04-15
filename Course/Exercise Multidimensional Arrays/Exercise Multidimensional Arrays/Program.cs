

int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size,size];

for (int row = 0; row < size; row++)
{
	int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int col = 0; col < size; col++)
	{
		matrix[row,col] = numbers[col];
	}
}

int sumX = 0;
int sumY = 0;

for (int x = 0, y = matrix.GetLength(0) - 1; x < size && y >= 0; x++, y--)
{
	sumX += matrix[x, x];
	sumY += matrix[x, y];
}

Console.WriteLine(Math.Abs(sumX - sumY));
