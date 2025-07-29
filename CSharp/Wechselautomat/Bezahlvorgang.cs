namespace Wechselautomat;

public class Bezahlvorgang
{
    public static decimal BerechneWechselgeld(decimal preis, decimal bezahlt)
    {
        if (preis < 0 || bezahlt < 0)
            throw new ArgumentException("Preis und bezahlter Betrag dürfen nicht negativ sein.");
        if (bezahlt < preis)
            throw new ArgumentException("Der bezahlte Betrag muss mindestens so hoch sein wie der Preis.");
        return bezahlt - preis;
    }
}