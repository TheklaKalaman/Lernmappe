namespace FizzBuzz;

internal class FizzBuzzLogik
{
    public string ReturnLogik(int divident)
    {
        if (divident % 3 == 0 && divident % 5 == 0)
            return "FizzBuzz!";
        else if (divident % 3 == 0)
            return "Fizz!";
        else if (divident % 5 == 0)
            return "Buzz!";
        else
            return divident.ToString();
    }
}
    