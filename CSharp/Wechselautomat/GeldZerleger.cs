namespace Wechselautomat;

public class GeldZerleger
{
    public static Dictionary<EuroUndCents.Geldstueck, int> InScheineUndMuenzenZerlegen(decimal betrag)
    {
        if (betrag <= 0)
            throw new ArgumentException("Betrag darf nicht negativ oder 0 sein.");

        var result = new Dictionary<EuroUndCents.Geldstueck, int>();

        foreach (var geldstueck in EuroUndCents.Alle)
        {
            int anzahl = (int)(betrag / geldstueck.Wert);
            if (anzahl > 0)
            {
                result[geldstueck] = anzahl;
                betrag -= anzahl * geldstueck.Wert;
                //betrag = Math.Round(betrag, 2, MidpointRounding.AwayFromZero);
            }
        }
        return result;
    }
}