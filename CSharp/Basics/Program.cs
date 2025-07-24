
// Coursera: Basics of C# Programming and Object-Oriented Development



internal class Program
{
    private static void Main(string[] args)
    {

        // Anwendung einer for-Schleife in C#

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }


        // Anwendung von Methoden der Klasse Calculator

        Console.WriteLine("Die Summe ist: " + Calculator.Add());
        Console.WriteLine("Die Differenz ist: " + Calculator.Subtract());
        Console.WriteLine("Das Produkt ist: " + Calculator.Multiply());
        Console.WriteLine("Der Quotient ist: " + Calculator.Divide());
    }
}