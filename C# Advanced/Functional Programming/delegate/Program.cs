

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

internal class Program
{
    delegate decimal VAT(decimal number);

    delegate decimal CominedNumbers(decimal a, decimal b);      

    static void Main(string[] args)
    {
        decimal[] numbers = Console.ReadLine().Split(", ").Select(decimal.Parse).ToArray();

        VAT addVat = x => x * 1.2m; 
        CominedNumbers multiply = (x,y) => x * y;
        CominedNumbers divide = (x, y) => x / y;

        foreach (var number in numbers)
        {
            Console.WriteLine($"{addVat(number):f2}");
        }

        Console.WriteLine("TEST");

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            Console.WriteLine(divide(numbers[i], numbers[i + 1]));
        }
    }
}
