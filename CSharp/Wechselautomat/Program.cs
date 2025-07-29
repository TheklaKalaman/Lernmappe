using Wechselautomat;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wechselautomat gestartet. Geben Sie einen Preis ein (z.B. 10.50):");
        string? preis = Console.ReadLine();

        if (string.IsNullOrEmpty(preis))
        {
            Console.WriteLine("Preis darf nicht leer sein.");
            return;
        }

        Console.WriteLine("Geben Sie den bezahlten Betrag ein (z.B. 20.00):");
        string? bezahlt = Console.ReadLine();

        if (string.IsNullOrEmpty(bezahlt))
        {
            Console.WriteLine("Bezahlter Betrag darf nicht leer sein.");
            return;
        }

        Console.WriteLine("Berechne Wechselgeld...");

        try
        {
            string? automat = Wechselautomat.Wechselautomat.Start(preis, bezahlt);

            if (automat == null)
            {
                Console.WriteLine("Kein Wechselgeld erforderlich.");
                return;
            }

            decimal betrag = Bezahlvorgang.BerechneWechselgeld(decimal.Parse(preis), decimal.Parse(bezahlt));
            
            Console.WriteLine("Wechselgeld: " + betrag + "");
            Console.WriteLine(automat);
        }

        catch (FormatException)
        {
            Console.WriteLine(Fehlermeldungen.FalschesFormat);
        }
        
        catch (Exception ex)
        {
            Console.WriteLine(Fehlermeldungen.UnerwarteterFehler + ex.Message);
        }
        finally
        {
            Console.WriteLine("Wechselautomat beendet.");
        }
        
    }
}