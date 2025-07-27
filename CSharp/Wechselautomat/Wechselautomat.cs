using System.Net.Http.Headers;

public class Wechselautomat
{
    public void Start()
    {
        Console.WriteLine("Willkommen beim Wechselautomaten!");
        Console.WriteLine("Bitte geben Sie den zu zahlenden Betrag ein (z.B. 10.50):");
        MoneyMoney zuZahlen = new MoneyMoney(decimal.Parse(Console.ReadLine()));
        MoneyMoney bezahlt = new MoneyMoney(decimal.Parse(Console.ReadLine()));
        Fehlermeldungen.Exceptions(zuZahlen, bezahlt);
        StarteBezahlvorgang(zuZahlen, bezahlt);
    }


    public void StarteBezahlvorgang(MoneyMoney verlangt, MoneyMoney gegeben)
    {
        Bezahlung bezahlung = new Bezahlung(verlangt, gegeben);
        MoneyMoney bezahlt = bezahlung.BerechneDifferenz();

        if (bezahlt.Vorkomma > 0 || bezahlt.Nachkomma > 0)
        {
            Console.WriteLine($"Sie erhalten zurück: {bezahlt.Vorkomma}.{bezahlt.Nachkomma:D2} Euro");
        }
        else
        {
            Console.WriteLine("Der Betrag wurde passend bezahlt.");
        }
    }
}