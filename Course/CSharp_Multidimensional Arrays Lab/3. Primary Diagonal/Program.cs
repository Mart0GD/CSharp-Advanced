

int input = int.Parse(Console.ReadLine());

int[,] matrix = new int[input, input];

for (int row = 0; row < input; row++)
{
	int[] numbersToPutIn = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int col = 0; col < input; col++)
	{
		matrix[row, col] = numbersToPutIn[col];
	}
}

int sum = 0;

for (int row = 0; row < input; row++)
{
	sum += matrix[row, row];
}

Console.WriteLine(sum);