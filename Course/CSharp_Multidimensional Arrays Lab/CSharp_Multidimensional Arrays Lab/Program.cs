﻿
int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int[,] matrix = new int[input[0], input[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
	int[] numbersToPutInMatirx = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		matrix[row, col] = numbersToPutInMatirx[col];
	}
}

int sum = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
		sum += matrix[row, col];
    }
}

Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix.GetLength(1));
Console.WriteLine(sum);