public class FizzBuzz
{
    public static void FizzBuzzGame()
    {
        Console.WriteLine("Bitte geben Sie eine Zahl ein:");
        string? n = Console.ReadLine();
        FizzBuzzCounter(n);
    }

    //FizzBuzzLogik
    private static String FizzBuzzLogik(int divident)
    {
        String FizzBuzz = "FizzBuzz!";
        String Fizz = "Fizz!";
        String Buzz = "Buzz!";

        if (divident % 3 == 0 && divident % 5 == 0)
        {
            Console.WriteLine(FizzBuzz);
        }
        else if (divident % 3 == 0)
        {
            Console.WriteLine(Fizz);
        }
        else if (divident % 5 == 0)
        {
            Console.WriteLine(Buzz);
        }
        else
        {
            Console.WriteLine(divident.ToString());
        }
        return "";
    }

    //FizzBuzzCounter
    private static String FizzBuzzCounter(String n)
    {

        int number = int.Parse(n);

        String result = "";
        if (number <= 0 || int.TryParse(n, out number) == false || n == null || n == "")
        {
            Console.WriteLine("Bitte geben Sie eine positive Zahl ein.");
            FizzBuzzCounter(Console.ReadLine());
        }
        else
        {
            for (int divident = 1; divident <= number; divident++)
            {
                FizzBuzzLogik(divident);
            }
        }
        return result;
    }
}
    