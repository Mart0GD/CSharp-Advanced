

int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
	string[] input = Console.ReadLine().Split();

	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = input[col];
	}
}

string command;

while ((command = Console.ReadLine()) != "END")
{
	string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

	if (!ValidateInput(tokens, rows, cols))
	{
		Console.WriteLine("Invalid input!");
		continue;
	}

	string temp = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
	matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = temp;
    PrintMatrix(rows, cols, matrix);
}


bool ValidateInput(string[] tokens, int rows, int cols)
{
	return tokens[0] == "swap" &&
		   tokens.Length == 5 &&
		   int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows &&
		   int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols &&
		   int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows &&
		   int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols;

}

static void PrintMatrix(int rows, int cols, string[,] matrix)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}