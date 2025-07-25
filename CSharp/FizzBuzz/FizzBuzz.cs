using System.Runtime.CompilerServices;

namespace FizzBuzz;

public class FizzBuzzy
{
    private readonly TextReader _reader;
    private readonly TextWriter _writer;

    public FizzBuzzy(TextReader reader, TextWriter writer)
    {
        _reader = reader;
        _writer = writer;
    }

    public void FizzBuzzGame()
    {
        Console.WriteLine("Bitte geben Sie eine Zahl ein:");
        int n = FizzBuzzInput();
        FizzBuzzCounter(n);
    }


    internal int FizzBuzzInput()
    {
        int number = 0;

        while (!int.TryParse(_reader.ReadLine(), out number) || number <= 0)
        {
            Console.WriteLine("Bitte geben Sie eine positive Zahl ein.");
        }

        return number;
    }

    internal void FizzBuzzCounter(int number)
    {
        var logik = new FizzBuzzLogik();

        for (int divident = 1; divident <= number; divident++)
        {
            String output = logik.ReturnLogik(divident);
            _writer.WriteLine(output);
        }
    }
}
    