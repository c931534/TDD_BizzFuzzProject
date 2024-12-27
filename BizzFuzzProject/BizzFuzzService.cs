namespace BizzFuzzProject;

public class BizzFuzzService
{
    public string Query(int number)
    {
        if ((number.ToString().Contains("3") || number % 3 == 0) && number % 5 != 0)
            return "Bizz";
        if (number % 5 == 0 && number % 3 == 0)
            return "BizzFuzz";
        if (number % 5 == 0)
            return "Fuzz";
        return number.ToString();
    }
}