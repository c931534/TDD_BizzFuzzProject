namespace BizzFuzzProject;

public class BizzFuzzService
{
    public string Query(int number)
    {
        if (IsBizz(number) && number % 5 != 0)
            return "Bizz";
        if (number % 5 == 0 && IsBizz(number))
            return "BizzFuzz";
        if (number % 5 == 0)
            return "Fuzz";
        return number.ToString();
    }

    private bool IsBizz(int number)
    {
        return number.ToString().Contains("3") || number % 3 == 0;
    }
}