

using System.Numerics;

int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows, cols];

string word = Console.ReadLine();

Queue<char> snake = new(word);

for (int row = 0; row < rows; row++)
{
	if (row % 2 == 0)
	{
		for (int col = 0; col < cols; col++)
		{
			if (!snake.Any())
			{
				 snake = new(word);
			}

            matrix[row, col] = snake.Dequeue();
        }
	}
	else
	{
		if (!snake.Any())
		{
			snake = new(word);
		}
		else
		{
			snake.Reverse();
		}

		for (int col = cols - 1; col >= 0; col--)
		{
            if (!snake.Any())
            {
                snake = new(word);
            }

            matrix[row, col] = snake.Dequeue();
        }
	}
}

for (int row = 0; row < rows; row++)
{
	for (int col = 0; col < cols; col++)
	{
		Console.Write($"{matrix[row,col]}");
	}
	Console.WriteLine();
}