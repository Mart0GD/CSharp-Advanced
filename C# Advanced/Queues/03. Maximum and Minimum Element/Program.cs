using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

int numberOfQueries = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < numberOfQueries; i++)
{
    int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

	if (command.First() == 1)
	{
        stack.Push(command.Last());
	}
	else if (command.First() == 2)
	{
        stack.Pop();
	}
    else if (command.First() == 3)
    {
        if (stack.Any()) Console.WriteLine(stack.Max()); 
    }
    else if (command.First() == 4)
    {
        if (stack.Any()) Console.WriteLine(stack.Min());
    }

}
    Console.WriteLine(string.Join(", ", stack));