using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numbersToPush = input.First();
            int numbersToPop = input[1];
            int numberToLookFor = input.Last();

            Stack<int> stack = new(Console.ReadLine().Split().Select(int.Parse));

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numberToLookFor))
            {
                Console.WriteLine("true");
            }
            else if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}