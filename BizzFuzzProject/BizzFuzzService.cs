namespace BizzFuzzProject;

public class BizzFuzzService
{
    public static string Query(int number)
    {
        if(number % 3 == 0)
            return "Bizz";
        return number.ToString();
    }
}