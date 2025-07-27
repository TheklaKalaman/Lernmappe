public class Bezahlung
{
    MoneyMoney ZuZahlen;
    MoneyMoney Bezahlt;
    Kundenabfrage kundenAbfrage = new Kundenabfrage();
    
    public Bezahlung(MoneyMoney verlangt, MoneyMoney gegeben)
    {
        ZuZahlen = verlangt;
        Bezahlt = gegeben;
    }

    public MoneyMoney BerechneDifferenz()
    {
        MoneyMoney diff = ZuZahlen.Differenz(Bezahlt);
        kundenAbfrage.ZuZahlen = ZuZahlen;
        kundenAbfrage.Bezahlt = Bezahlt;

        try
        {
            Fehlermeldungen.Exceptions(ZuZahlen, Bezahlt);
            return diff;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Fehler: {ex.Message}");

            if (ex.Message.Contains("Der bezahlte Betrag ist kleiner als der zu zahlende Betrag."))
            {
                Console.WriteLine($"Noch zu zahlen: {diff}");

                MoneyMoney nachzahlung = kundenAbfrage.FrageUserNachMehrGeld();
                Bezahlt = Bezahlt.Summe(nachzahlung);
                diff = ZuZahlen.Differenz(Bezahlt);
            }
            else
            {
                Console.WriteLine("Vorgang abgebrochen.");
                return new MoneyMoney(0);
            }
        }
        return diff;
    }

}