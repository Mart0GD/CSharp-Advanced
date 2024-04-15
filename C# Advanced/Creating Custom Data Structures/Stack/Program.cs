
using Stack;
using System;


Stack.Stack stack = new();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

while (!stack.IsEmpty)
{
    Console.WriteLine(stack.Pop());
}

