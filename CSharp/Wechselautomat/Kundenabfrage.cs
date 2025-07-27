public class Kundenabfrage
{
    public MoneyMoney ZuZahlen { get; set; }
    public MoneyMoney Bezahlt { get; set; }

    public MoneyMoney FrageUserNachMehrGeld()
    {
        MoneyMoney verlangt = ZuZahlen;
        MoneyMoney bezahlt = Bezahlt;

        while (true)
        {
            try
            {
                Console.WriteLine("Bitte geben Sie den zusätzlichen Betrag ein, den Sie zahlen möchten (z.B. 5.00):");
                string input = Console.ReadLine();
                bezahlt = bezahlt.Summe(MoneyMoney.Parse(input));
                MoneyMoney rest = bezahlt.Differenz(verlangt);

                if ((rest.Vorkomma > 0) || (rest.Nachkomma > 0))
                {
                    Console.WriteLine($"Noch zu zahlen: {rest}");
                    continue;
                }
                else
                {
                    Console.WriteLine("Betrag vollständig bezahlt.");
                    break;
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }
        return bezahlt;
    }
}