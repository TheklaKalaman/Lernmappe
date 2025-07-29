namespace Wechselautomat;

public static class Wechselautomat
{
    public static string? Start(string? preis, string? bezahlt)
    {
        if (preis == null || bezahlt == null)
            throw new ArgumentNullException("Preis und bezahlter Betrag dürfen nicht null sein.");
        
        decimal preisDecimal = GeldFormatierer.ParseBetrag(preis);
        decimal bezahltDecimal = GeldFormatierer.ParseBetrag(bezahlt);

        if (preisDecimal <= 0 || bezahltDecimal <= 0)
            throw new ArgumentException("Preis und bezahlter Betrag dürfen nicht negativ oder 0 sein.");

        string? eingabe = Bezahlvorgang.BerechneWechselgeld(preisDecimal, bezahltDecimal).ToString(); 
        decimal betrag = GeldFormatierer.ParseBetrag(eingabe);
        Dictionary<EuroUndCents.Geldstueck, int> wechselgeld = GeldZerleger.InScheineUndMuenzenZerlegen(betrag);

        return GeldFormatierer.FormatierungDesWechselgeldTexts(wechselgeld);
    }        
}