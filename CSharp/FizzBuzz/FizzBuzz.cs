using System.Runtime.CompilerServices;

namespace FizzBuzz;

internal class FizzBuzzOutput
{
    public const String FizzBuzz = "FizzBuzz!";
    public const String Fizz = "Fizz!";
    public const String Buzz = "Buzz!";
}

internal class FizzBuzzLogik
{
    public string ReturnLogik(int divident)
    {
        // String FizzBuzz = "FizzBuzz!";
        // String Fizz = "Fizz!";
        // String Buzz = "Buzz!";

        if (divident % 3 == 0 && divident % 5 == 0)
        {
            return FizzBuzzOutput.FizzBuzz;
            // Console.WriteLine(FizzBuzz);
        }
        else if (divident % 3 == 0)
        {
            return FizzBuzzOutput.Fizz;
            // Console.WriteLine(Fizz);
        }
        else if (divident % 5 == 0)
        {
            return FizzBuzzOutput.Buzz;
            // Console.WriteLine(Buzz);
        }
        else
        {
            return divident.ToString();
            // Console.WriteLine(divident.ToString());
        }
        // return "";
    }

}

public class FizzBuzzy
{
    public static void FizzBuzzGame()
    {
        Console.WriteLine("Bitte geben Sie eine Zahl ein:");
        int n = FizzBuzzInput();
        FizzBuzzCounter(n);
    }


    private static int FizzBuzzInput()
    {
        int number = 0;

        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Bitte geben Sie eine positive Zahl ein.");
        }

        return number;
    }

    private static void FizzBuzzCounter(int number)
    {
        var logik = new FizzBuzzLogik();

        for (int divident = 1; divident <= number; divident++)
        {
            String output = logik.ReturnLogik(divident);
            Console.WriteLine(output);
        }
    }
}
    