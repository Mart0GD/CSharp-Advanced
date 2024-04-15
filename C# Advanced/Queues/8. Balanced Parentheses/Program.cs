Stack<char> parentheses = new();

string input = Console.ReadLine();


bool balanced = true;
foreach (var bracket in input)
{
    switch (bracket)
    {
        case '{':
        case '[':
        case '(':

            parentheses.Push(bracket);

            break;

        case '}':

            if (!parentheses.Any() || parentheses.Pop() != '{')
            {
                balanced = false;
            }

            break;
        case ']':

            if (!parentheses.Any() || parentheses.Pop() != '[')
            {
                balanced = false;
            }

            break;
        case ')':

            if (!parentheses.Any() || parentheses.Pop() != '(')
            {
                balanced = false;
            }

            break;

    }
}

if (balanced && !parentheses.Any())
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}