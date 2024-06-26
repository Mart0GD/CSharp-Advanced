﻿
int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
	int[] numbersToPutInMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = numbersToPutInMatrix[col];
	}
}

for (int col = 0; col < cols; col++)
{
	int sum = 0;
	for (int row = 0; row < rows; row++)
	{
		sum += matrix[row, col];
	}
	Console.WriteLine(sum);
}