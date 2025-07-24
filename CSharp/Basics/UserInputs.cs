public class UserInputs
{
    public static int GetInputAndParse(string prompt)
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();
        int number;
        while (input == null || !int.TryParse(input, out number))
        {
            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            input = Console.ReadLine();
        }
        
        return number;
    }
}