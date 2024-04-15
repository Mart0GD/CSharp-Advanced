
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {   
            int n = int.Parse(Console.ReadLine());


            Family poll = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                poll.AddMember(new Person(input[0], int.Parse(input[1])));
            }

            foreach (var member in poll.Members.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}

