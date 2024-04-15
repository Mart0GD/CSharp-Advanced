
HashSet<string> vipGuests = new();
HashSet<string> regularGuests = new();

string command;
while ((command = Console.ReadLine()) != "PARTY")
{
    string guest = command;

	if (Char.IsDigit(guest.FirstOrDefault()))
	{
		vipGuests.Add(guest);
	}
	else
	{
		regularGuests.Add(guest);
	}
}

while ((command = Console.ReadLine()) != "END")
{
    string guest = command;

    if (Char.IsDigit(guest.FirstOrDefault()) && vipGuests.Contains(guest))
    {
        vipGuests.Remove(guest);
    }
    else if (regularGuests.Contains(guest))
    {
        regularGuests.Remove(guest);
    }
}

Console.WriteLine(vipGuests.Count + regularGuests.Count);

vipGuests.ToList().ForEach(x => Console.WriteLine(x));
regularGuests.ToList().ForEach(x => Console.WriteLine(x));