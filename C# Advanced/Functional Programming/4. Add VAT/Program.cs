

decimal[] numbers = Console.ReadLine().Split(", ").Select(decimal.Parse).ToArray();

Func<decimal, decimal> addVAT = AddVAT;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{addVAT(numbers[i]):f2}");
}


decimal AddVAT(decimal number)
{
    return number * 1.20m;
}