

string[] sentence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<char, bool> isUpper = CheckUpper;

string[] upperWords = sentence.Where(x => isUpper(x.First())).ToArray();

foreach (var word in upperWords)
{
    Console.WriteLine(word);
}


bool CheckUpper(char arg)
{
    return Char.IsUpper(arg);
}