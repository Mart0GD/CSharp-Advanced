

int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
	string[] chars = Console.ReadLine().Split();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = char.Parse(chars[col]);
	}
}

int sameSquares = 0;
for (int row = 0; row < rows - 1; row++)
{
	for (int col = 0; col < cols - 1; col++)
	{
        bool same = false;
        char currentChar = matrix[row, col];
		
		if (matrix[row,col + 1] == currentChar &&
			matrix[row + 1,col] == currentChar &&
			matrix[row + 1,col + 1] == currentChar
			)
		{
			same = true;
		}

        sameSquares += same ? 1 : 0;
    }

	
}

Console.WriteLine(sameSquares);