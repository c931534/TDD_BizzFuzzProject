namespace BizzFuzzProject;

public class BizzFuzzService
{
    public string Query(int number)
    {
        if(number % 5 ==0 && number % 3 == 0)
return "BizzFuzz";
        if (number % 5 == 0)
            return "Fuzz";
        if(number % 3 == 0)
            return "Bizz";
        return number.ToString();
    }
}