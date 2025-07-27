public static class Fehlermeldungen
{
    // MoneyMoney ZuZahlen;
    // MoneyMoney Bezahlt;

    public static void Exceptions(MoneyMoney zuZahlen, MoneyMoney bezahlt)
    {
        if (zuZahlen == null || bezahlt == null)
        {
            throw new InvalidOperationException("Beträge müssen gesetzt sein.");
        }
        if (zuZahlen.Vorkomma < 0 || bezahlt.Vorkomma < 0)
        {
            throw new InvalidOperationException("Beträge dürfen nicht negativ sein.");
        }
        if (zuZahlen.Nachkomma < 0 || bezahlt.Nachkomma < 0)
        {
            throw new InvalidOperationException("Nachkommabeträge dürfen nicht negativ sein.");
        }
        if (zuZahlen.Vorkomma == 0 && zuZahlen.Nachkomma == 0)
        {
            throw new InvalidOperationException("Der zu zahlende Betrag darf nicht null sein.");
        }
        if (bezahlt.Vorkomma == 0 && bezahlt.Nachkomma == 0)
        {
            throw new InvalidOperationException("Der bezahlte Betrag darf nicht null sein.");
        }
        if (bezahlt.Vorkomma < zuZahlen.Vorkomma ||
            (bezahlt.Vorkomma == zuZahlen.Vorkomma && bezahlt.Nachkomma < zuZahlen.Nachkomma))
        {
            throw new InvalidOperationException("Der bezahlte Betrag ist kleiner als der zu zahlende Betrag.");
        }
    }
}