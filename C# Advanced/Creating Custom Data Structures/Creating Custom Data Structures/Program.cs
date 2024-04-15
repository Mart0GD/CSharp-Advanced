

using Creating_Custom_Data_Structures;

CustomList list = new();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(8);
list.Add(11);
list.Add(22);
list.Add(37);


Console.WriteLine("Initially");

Console.WriteLine(string.Join(" ", list.ToArray()));

Console.WriteLine("Remove");
list.RemoveAt(2);

Console.WriteLine(string.Join(" ", list.ToArray()));

Console.WriteLine("Insert");
list.InsertAt(3, 2);

Console.WriteLine(string.Join(" ", list.ToArray()));

Console.WriteLine("Swap");
list.Swap(4, 1);

Console.WriteLine(string.Join(" ", list.ToArray()));

Console.WriteLine("Contains - 4");

Console.WriteLine(list.Contains(4));