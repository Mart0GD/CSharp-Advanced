

namespace DateModifier;

public class DateModifier
{
    public int GetDiffrence(DateTime d1, DateTime d2)
    {
        TimeSpan difference = d2 - d1;


        return Math.Abs(difference.Days);
    }             
}