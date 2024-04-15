


using System.Text;

int operations = int.Parse(Console.ReadLine());

Stack<string> stack = new Stack<string>();

StringBuilder text = new StringBuilder();

for (int i = 0; i < operations; i++)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int commandNumber = int.Parse(command.First());

    if (commandNumber == 1)
    {
        stack.Push(text.ToString());
        text.Append(command.Last());
    }
    else if (commandNumber == 2)
    {
        int count = int.Parse(command.Last());

        string toRemove = string.Join("", text.ToString().TakeLast(count));


        stack.Push(text.ToString());
        text.Remove(text.Length - count, count);
        //text.Replace(toRemove, "");
    }
    else if (commandNumber == 3)
    {
        int index = int.Parse(command.Last());

        Console.WriteLine(text[index - 1]);
    }
    else if (commandNumber == 4)
    {
        text.Clear();
        text.Append(stack.Pop());
    }
}