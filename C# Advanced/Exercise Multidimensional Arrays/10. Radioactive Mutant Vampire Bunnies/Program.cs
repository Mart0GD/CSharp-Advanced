

using System.Data;

int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rows = size[0];
int cols = size[1];

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    string input = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input[col];
    }
}

char[] commands = Console.ReadLine().ToCharArray();

Tuple<int, int> playerPos = GetPlayerPos(rows, cols, matrix);

int playerRow = playerPos.Item1;
int playerCol = playerPos.Item2;

for (int i = 0; i < commands.Length; i++)
{
    char command = commands[i];

    switch (command)
    {
        case 'U':

            if (ValidateRowIndex(playerRow - 1, matrix))
            {
                playerRow -= 1;
            }
            else
            {
                MoveBunnies(rows, cols, matrix);
                Print(rows, cols, matrix);
                Console.WriteLine($"won: {playerRow} {playerCol}");
                return;
            }

            break;

        case 'D':

            if (ValidateRowIndex(playerRow + 1, matrix))
            {
                playerRow += 1;
            }
            else
            {
                MoveBunnies(rows, cols, matrix);
                Print(rows, cols, matrix);
                Console.WriteLine($"won: {playerRow} {playerCol}");
                return;
            }

            break;

        case 'L':

            if (ValidateColIndex(playerCol - 1, matrix))
            {
                playerCol -= 1;
            }
            else
            {
                MoveBunnies(rows, cols, matrix);
                Print(rows, cols, matrix);
                Console.WriteLine($"won: {playerRow} {playerCol}");
                return;
            }

            break;

        case 'R':

            if (ValidateColIndex(playerCol + 1, matrix))
            {
                playerCol += 1;
            }
            else
            {
                MoveBunnies(rows, cols, matrix);
                Print(rows, cols, matrix);
                Console.WriteLine($"won: {playerRow} {playerCol}");
                return;
            }

            break;
    }

    MoveBunnies(rows, cols, matrix);

    if (CheckForBunnies(playerRow, playerCol, matrix))
    {
        Print(rows,cols,matrix);
        Console.WriteLine($"dead: {playerRow} {playerCol}");
        break;
    }
   
}


bool ValidateColIndex(int v, char[,] matrix)
{
    return v >= 0 &&
          v < matrix.GetLength(1);
}

bool ValidateRowIndex(int index, char[,] matrix)
{
    return index >= 0 &&
           index < matrix.GetLength(0);
}

static Tuple<int, int> GetPlayerPos(int rows, int cols, char[,] matrix)
{
    for (int row = 0; row < rows; row++)
    {

        for (int col = 0; col < cols; col++)
        {
            if (matrix[row, col] == 'P')
            {
                matrix[row, col] = '.';
                return new Tuple<int, int>(row, col);
            }
        }
    }

    return null;
}

void MoveBunnies(int rows, int cols, char[,] matrix)
{
    List <Tuple<int, int>> bunnies= new();

    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            if (matrix[row,col] == 'B')
            {
                bunnies.Add(new Tuple<int, int>(row, col));
            }
        }
    }

    foreach (var bunny in bunnies)
    {
        int row = bunny.Item1;
        int col = bunny.Item2;

        if (ValidateRowIndex(row - 1, matrix)) matrix[row - 1, col] = 'B';
        if (ValidateRowIndex(row + 1, matrix)) matrix[row + 1, col] = 'B';
        if (ValidateColIndex(col - 1, matrix)) matrix[row, col - 1] = 'B';
        if (ValidateColIndex(col + 1, matrix)) matrix[row, col + 1] = 'B';
    }


}

static bool CheckForBunnies(int playerRow, int playerCol, char[,] matrix)
{
    if (matrix[playerRow, playerCol] == 'B')
    {
        return true;
    }

    return false;
}

static void Print(int rows, int cols, char[,] matrix)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}