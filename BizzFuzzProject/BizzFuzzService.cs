namespace BizzFuzzProject;

public class BizzFuzzService
{
    public string Query(int number)
    {
        if (IsFuzz(number) && !IsBizz(number))
            return "Fuzz";
        if (IsBizz(number) && !IsFuzz(number))
            return "Bizz";
        if (IsFuzz(number) && IsBizz(number))
            return "BizzFuzz";
        if (IsFuzz(number))
            return "Fuzz";
        return number.ToString();
    }

    private bool IsFuzz(int number)
    {
        return number.ToString().Contains("5") || number % 5 == 0;
    }

    private bool IsBizz(int number)
    {
        return number.ToString().Contains("3") || number % 3 == 0;
    }
}