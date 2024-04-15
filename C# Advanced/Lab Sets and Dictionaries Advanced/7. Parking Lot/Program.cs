
HashSet<string> parkingLot = new();

string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] tokens = command.Split(", ");

    string plate = tokens[1];
    string action = tokens[0];

    if (action == "IN")
    {
        parkingLot.Add(plate);
    }
    else if (action == "OUT")
    {
        parkingLot.Remove(plate);
    }

}

if (parkingLot.Any())
{
    foreach (var car in parkingLot)
    {
        Console.WriteLine(car);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}
