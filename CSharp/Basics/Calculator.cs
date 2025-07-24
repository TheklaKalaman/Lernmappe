using System.Security.Cryptography.X509Certificates;

public class Calculator
{
    public static int Add()
    {
        int a, b;
        a = UserInputs.GetInputAndParse("Bitte geben Sie die erste Zahl ein:");
        b = UserInputs.GetInputAndParse("Bitte geben Sie die zweite Zahl ein:");

        return a + b;
    }

    public static int Subtract()
    {
        int a, b;
        a = UserInputs.GetInputAndParse("Bitte geben Sie die erste Zahl ein:");
        b = UserInputs.GetInputAndParse("Bitte geben Sie die zweite Zahl ein:");

        return a - b;
    }

    public static int Multiply()
    {
        int a, b;
        a = UserInputs.GetInputAndParse("Bitte geben Sie die erste Zahl ein:");
        b = UserInputs.GetInputAndParse("Bitte geben Sie die zweite Zahl ein:");

        return a * b;
    }
    
    public static double Divide()
    {
        int a, b;
        a = UserInputs.GetInputAndParse("Bitte geben Sie die erste Zahl ein:");
        b = UserInputs.GetInputAndParse("Bitte geben Sie die zweite Zahl ein:");

        while (b == 0)
        {
            Console.WriteLine("Division durch Null ist nicht erlaubt.");
            b = UserInputs.GetInputAndParse("Bitte geben Sie eine andere Zahl für den Divisor ein:");
        }

        return (double)a / b;
    }
}