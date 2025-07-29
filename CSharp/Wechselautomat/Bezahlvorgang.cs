namespace Wechselautomat;

public class Bezahlvorgang
{
    public static decimal BerechneWechselgeld(decimal preis, decimal bezahlt)
    {
        if (preis < 0 || bezahlt < 0)
            throw new ArgumentException(Fehlermeldungen.BetragIstNegativOderNull);
        if (bezahlt < preis)
            throw new ArgumentException(Fehlermeldungen.BetragIstZuNiedrig);
        return bezahlt - preis;
    }
}