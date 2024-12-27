namespace BizzFuzzProject;

public class BizzFuzzService
{
    public string Query(int number)
    {
        if(number % 3 == 0)
            return "Bizz";
        return number.ToString();
    }
}