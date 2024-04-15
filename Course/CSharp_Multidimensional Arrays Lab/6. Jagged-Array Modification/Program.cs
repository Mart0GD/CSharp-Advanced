
using System.Numerics;

int rows = int.Parse(Console.ReadLine());

int[][] jagged = new int[rows][];

for (int row = 0; row < rows; row++)
{
    jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

string[] command = Console.ReadLine().Split();

while (string.Join("", command) != "END")
{
    string commandName = command[0];

    int row = int.Parse(command[1]);
    int col = int.Parse(command[2]);
    int value = int.Parse(command.Last());

    if (row < 0 || row >= jagged.Length)
    {
        Console.WriteLine("Invalid coordinates");

        command = Console.ReadLine().Split();
        continue;
    }
    if (col < 0 || col >= jagged[row].Length)
    {
        Console.WriteLine("Invalid coordinates");

        command = Console.ReadLine().Split();
        continue;
    }

    if (commandName == "Add")
    {
        jagged[row][col] += value;
    }
    else if (commandName == "Subtract")
    {
        jagged[row][col] -= value;
    }

    command = Console.ReadLine().Split();
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < jagged[row].Length; col++)
    {
        Console.Write($"{jagged[row][col]} ");
    }
    Console.WriteLine();
}