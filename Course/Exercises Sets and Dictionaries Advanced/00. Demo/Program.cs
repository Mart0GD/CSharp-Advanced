

Dictionary<int, int> demo = new();

demo.Add(1, 2);
demo.Add(3, 4);
demo.Add(5, 6);

demo.Remove(3);

demo.Add(100, 4);

foreach (var item in demo)
{
    Console.Write(item.Key);
    Console.WriteLine(item.Value);
}