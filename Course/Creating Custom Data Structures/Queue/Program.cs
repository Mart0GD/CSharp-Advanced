using Queue;
using System.Collections.Generic;

CustomQueue queue = new();

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(8);
queue.Enqueue(11);
queue.Enqueue(22);
queue.Enqueue(37);


Console.WriteLine("Initially");

queue.ForEach(x => Console.Write(x + " "));

Console.WriteLine();

Console.WriteLine("Swap");
queue.Swap(4, 1);

queue.ForEach(x => Console.Write(x + " "));

Console.WriteLine();

Console.WriteLine("Contains - 11");

Console.WriteLine(queue.Contains(11));

Console.WriteLine("Dequeue");

queue.Dequeue();
queue.Dequeue();
queue.Dequeue();

queue.ForEach(x => Console.Write(x + " "));