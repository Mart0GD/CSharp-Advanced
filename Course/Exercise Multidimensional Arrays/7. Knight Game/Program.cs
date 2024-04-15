

using System.ComponentModel;

int size = int.Parse(Console.ReadLine());

char[,] chessBoard = new char[size,size];

for (int row = 0; row < size; row++)
{
	char[] input = Console.ReadLine().ToCharArray();

	for (int col = 0; col < size; col++)
	{
		chessBoard[row, col] = input[col];
	}
}

int removedKnights = 0;
while (CheckBoard(size, ref chessBoard))
{
    removedKnights++;
}

Console.WriteLine(removedKnights);


bool CheckBoard(int size, ref char[,] chessBoard)
{
    bool collision = false;

    int mostHits = 0;
    int mostHitsCol = 0;
    int mostHitsRow = 0;


    for (int row = 0; row < size; row++)
    {

        for (int col = 0; col < size; col++)
        {
            if (chessBoard[row, col] == 'K')
            {
                int hitKnights = CheckCollision(row, col, chessBoard);

                if (hitKnights > mostHits)
                {
                    mostHits = hitKnights;
                    mostHitsCol = col;
                    mostHitsRow = row;
                }
            }
        }

    }

    if (mostHits != 0)
    {
        collision = true;
        chessBoard[mostHitsRow, mostHitsCol] = '0';

    }

    return collision;
}
int CheckCollision(int row, int col, char[,] chessBoard)
{
	int hits = 0;

	if (ValidateIndexes(row - 2,col - 1,chessBoard) && chessBoard[row - 2, col - 1] == 'K')
	{

        hits++;
	}

    if (ValidateIndexes(row - 2, col + 1, chessBoard) && chessBoard[row - 2, col + 1] == 'K')
    {
        hits++;
    }

    if (ValidateIndexes(row + 2, col - 1, chessBoard) && chessBoard[row + 2, col - 1] == 'K')
    {
        hits++;
    }

    if (ValidateIndexes(row + 2, col + 1, chessBoard) && chessBoard[row + 2, col + 1] == 'K') //
    {
        hits++;
    }

    if (ValidateIndexes(row - 1, col + 2, chessBoard) && chessBoard[row - 1, col + 2] == 'K')
    {
        hits++;
    }

    if (ValidateIndexes(row + 1, col + 2, chessBoard) && chessBoard[row + 1, col + 2] == 'K')
    {
        hits++;
    }

    if (ValidateIndexes(row - 1, col - 2, chessBoard) && chessBoard[row - 1, col - 2] == 'K')
    {
        hits++;
    }

    if (ValidateIndexes(row + 1, col -2, chessBoard) && chessBoard[row + 1, col - 2] == 'K')
    {
        hits++;
    }

    return hits;

}

bool ValidateIndexes(int row,int col, char[,] array)
{
	return row >= 0 && row < array.GetLength(0) &&
		   col >= 0 && col < array.GetLength(1);
}

