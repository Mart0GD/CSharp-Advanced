
using System.Collections.Generic;

Dictionary <string, Dictionary<string, List<string>>> citiesByContinentAndCountry = new();

int inputs = int.Parse(Console.ReadLine());

for (int i = 0; i < inputs; i++)
{
    string[] input = Console.ReadLine().Split();

    string continent = input.First();
    string country = input[1];
    string city = input.Last();

    if (!citiesByContinentAndCountry.ContainsKey(continent))
    {
        citiesByContinentAndCountry.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!citiesByContinentAndCountry[continent].ContainsKey(country))
    {
        citiesByContinentAndCountry[continent].Add(country, new List<string>());
    }

    citiesByContinentAndCountry[continent][country].Add(city);
}

foreach (var continent in citiesByContinentAndCountry)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var (country, cities) in continent.Value)
    {
        Console.WriteLine($"{country} -> {string.Join(", ", cities)}");
    }
}