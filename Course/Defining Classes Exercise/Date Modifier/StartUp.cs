
namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {   
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            DateTime d2 = DateTime.Parse(Console.ReadLine());

            DateModifier modifier = new DateModifier();

            Console.WriteLine(modifier.GetDiffrence(d1, d2));
        }
    }
}

