namespace Wechselautomat;

public static class Wechselautomat
{
    public static String Start(String eingabe)
    {
        decimal betrag = GeldFormatierer.ParseBetrag(eingabe);
        Dictionary<decimal, int> wechselgeld = GeldZerleger.InScheineUndMuenzenZerlegen(betrag);

        return GeldFormatierer.FormatierungDesWechselgeldTexts(wechselgeld);
    }        
}