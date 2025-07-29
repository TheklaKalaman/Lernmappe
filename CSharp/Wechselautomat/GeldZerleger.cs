namespace Wechselautomat;

public class GeldZerleger
{
    public static Dictionary<decimal, int> InScheineUndMuenzenZerlegen(decimal betrag)
    {
        if (betrag <= 0)
            throw new ArgumentException("Betrag darf nicht negativ oder 0 sein.");

        var result = new Dictionary<decimal, int>();

        foreach (var wert in EuroUndCents.Geldstuecke)
        {
            int anzahl = (int)(betrag / wert);
            if (anzahl > 0)
            {
                result[wert] = anzahl;
                betrag -= anzahl * wert;
                betrag = Math.Round(betrag, 2, MidpointRounding.AwayFromZero);
            }
        }
        return result;
    }

}