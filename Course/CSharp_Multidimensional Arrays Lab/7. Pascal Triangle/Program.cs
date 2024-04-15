

using System;

int rows = int.Parse(Console.ReadLine());

long[][] pascalTriangle = new long[rows][];

pascalTriangle[0] = new long[1] {1};

for (int row = 1; row < rows; row++)
{
    pascalTriangle[row] = new long[row + 1];

	for (int col = 0; col < pascalTriangle[row].Length; col++)
	{
		pascalTriangle[row][col] = (col == pascalTriangle[row].Length - 1 ? 0 : pascalTriangle[row - 1][col]) + (col == 0 ? 0 : pascalTriangle[row - 1][col - 1]);
	}
}

for (int row = 0; row < rows; row++)
{
	for (int col = 0; col < pascalTriangle[row].Length; col++)
	{
		Console.Write($"{pascalTriangle[row][col]} ");
	}
	Console.WriteLine();
}