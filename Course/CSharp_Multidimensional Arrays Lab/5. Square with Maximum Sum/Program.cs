int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

Console.WriteLine("Please put in square parameters");

int[] squareParam = Console.ReadLine().Split().Select(int.Parse).ToArray();

int height = squareParam[0];
int width = squareParam[1];

for (int row = 0; row < rows; row++)
{
    int[] numbersToPutIn = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = numbersToPutIn[col];
    }
}

int maxSum = 0;
int topLeftRow = 0;
int topLeftCol = 0;

for (int row = 0; row < rows - 1; row++)
{

    for (int col = 0; col < cols - 1; col++)
    {
        int currentSum = 0;
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (row + y == rows || col + x == cols)
                {
                    break;
                }
                currentSum += matrix[row + y, col + x];
            }
        }

        //currentSum += matrix[row, col];
        //currentSum += matrix[row, col + 1];
        //currentSum += matrix[row + 1, col];
        //currentSum += matrix[row + 1, col + 1];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            topLeftRow = row;
            topLeftCol = col;
        }
    }
}

for (int row = topLeftRow; row < topLeftRow + height; row++)
{
    for (int col = topLeftCol; col < topLeftCol + width; col++)
    {
        Console.Write($"{matrix[row,col]} ");
    }
    Console.WriteLine();
}


//Console.WriteLine($"{matrix[topLeftRow, topLeftCol]} {matrix[topLeftRow, topLeftCol + 1]}");
//Console.WriteLine($"{matrix[topLeftRow + 1, topLeftCol]} {matrix[topLeftRow + 1, topLeftCol + 1]}");
//Console.WriteLine(maxSum);