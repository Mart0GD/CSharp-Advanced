

int size = int.Parse(Console.ReadLine());

string[,] matrix = new string[size, size];

string[] commands = Console.ReadLine().Split();

for (int row = 0;row < size; row++)
{
	string[] input = Console.ReadLine().Split();

	for (int col = 0; col < size; col++)
	{
		matrix[row, col] = input[col];	
	}
}

Tuple<int, int> miner = GetMiner(size,matrix);
int CoalCount = GetCoalCount(size,matrix);

int coal = 0; 

int minerRow = miner.Item1;
int minerCol = miner.Item2;

for (int i = 0; i < commands.Length; i++)
{
	string command = commands[i];

	switch (command)
	{
		case "up":
            minerRow -= ValidateIndex(minerRow - 1, matrix) ? 1 : 0;
			break;

        case "down":
            minerRow += ValidateIndex(minerRow + 1, matrix) ? 1 : 0;
            break;

        case "left":
            minerCol -= ValidateIndex(minerCol - 1, matrix) ? 1 : 0;
            break;

        case "right":
            minerCol += ValidateIndex(minerCol + 1, matrix) ? 1 : 0;
            break;
    }

    if (matrix[minerRow,minerCol] == "c")
    {
        matrix[minerRow, minerCol] = "*";
        coal++;

        if (coal == CoalCount)
        {
            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
            return;
        }
    }
    else if (matrix[minerRow,minerCol] == "e")
    {
        Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
        return;
    }
}

Console.WriteLine($"{CoalCount - coal} coals left. ({minerRow}, {minerCol})");



static int GetCoalCount(int size, string[,] matrix)
{
    int coal = 0;

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (matrix[row, col] == "c")
            {
                coal++;
            }
        }
    }

    return coal;
}


static Tuple<int,int> GetMiner(int size, string[,] matrix)
{
    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (matrix[row, col] == "s")
            {
                return new Tuple<int,int>(row, col);
            }
        }
    }

    return null;
}

bool ValidateIndex(int index, string[,] matrix)
{
    return index >= 0 &&
           index < matrix.GetLength(0);
}