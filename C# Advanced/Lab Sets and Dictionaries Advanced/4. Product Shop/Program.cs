

Dictionary<string, Dictionary<string, double>> productShops = new();

string command;
while ((command = Console.ReadLine()) != "Revision")
{
    string[] tokens = command.Split(", ");

    string shop = tokens.First();
    string product = tokens[1];
    double price = double.Parse(tokens.Last());

    if (!productShops.ContainsKey(shop))
    {
        productShops.Add(shop, new Dictionary<string, double>());
    }

    if (!productShops[shop].ContainsKey(product))
    {
        productShops[shop].Add(product, price);
    }
}

foreach (var (shop, products) in productShops.OrderBy(x => x.Key))
{
    Console.WriteLine($"{shop}->");
    foreach (var (product, price) in products)
    {
        Console.WriteLine($"Product: {product}, Price: {price}");
    }
}