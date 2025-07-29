namespace Wechselautomat;

public static class Wechselautomat
{
    public static string? Start(string? preis, string? bezahlt)
    {
        if (preis == null || bezahlt == null)
            throw new ArgumentNullException(Fehlermeldungen.BetragIstNull);
        
        decimal preisDecimal = GeldFormatierer.ParseBetrag(preis);
        decimal bezahltDecimal = GeldFormatierer.ParseBetrag(bezahlt);

        if (preisDecimal <= 0 || bezahltDecimal <= 0)
            throw new ArgumentException(Fehlermeldungen.BetragNegativOderNull);

        decimal wechselgeldBetrag = Bezahlvorgang.BerechneWechselgeld(preisDecimal, bezahltDecimal);
        if (wechselgeldBetrag == 0)
            return null;
        var wechselgeld = GeldZerleger.InScheineUndMuenzenZerlegen(wechselgeldBetrag);
        
        return GeldFormatierer.FormatierungDesWechselgeldTexts(wechselgeld);
    }        
}