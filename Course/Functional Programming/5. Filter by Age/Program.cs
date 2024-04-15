

int n = int.Parse(Console.ReadLine());

List<Person> people = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

    people.Add(new Person(input[0], int.Parse(input[1])));
}

string ageCondition = Console.ReadLine();
int ageFilter = int.Parse(Console.ReadLine());

string printformat = Console.ReadLine();

List<Person> filtertedPeople = people.Where(x => GetFilterFunction(ageCondition,ageFilter)(x.Age)).ToList();

Action<Person> print = GetPrintType(printformat);

foreach (var person in filtertedPeople)
{
    print(person);
}


Func<int, bool> GetFilterFunction(string ageCondition, int age)
{
    switch (ageCondition)
    {
        case "younger":
            return x => x < age;
        case "older":
            return x => x >= age;
        default:
            break;
    }

    return null;
}


Action<Person> GetPrintType(string format)
{
    switch (format)
    {
        case "name age":
            return x => Console.WriteLine($"{x.Name} - {x.Age}");
        case "age":
            return x => Console.WriteLine($"{x.Age}");
        case "name":
            return x => Console.WriteLine($"{x.Name}");
        default:
            break;
    }

    return null;
}



public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }
}