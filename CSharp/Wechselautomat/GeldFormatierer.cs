namespace Wechselautomat;

public class GeldFormatierer
{
    public static string? FormatierungDesWechselgeldTexts(Dictionary<EuroUndCents.Geldstueck, int> dict)
    {
        List<string> teile = new();

        foreach (var x in dict.OrderByDescending(x => x.Key.Wert))
        {
            var geldstueck = x.Key;
            int anzahl = x.Value;

            bool istEuro = geldstueck.IstEuro;
            string wertText = geldstueck.Bezeichnung;

            string einheit = istEuro
                ? (anzahl == 1 ? "Schein" : "Scheine")
                : (anzahl == 1 ? "Münze" : "Münzen");

            teile.Add($"{anzahl} x {wertText} {einheit}");
        }

        return string.Join("\n", teile);
    }

    public static decimal ParseBetrag(string eingabe)
    {
        string? normiert = eingabe.Replace('.', ',');
        return decimal.Parse(normiert, System.Globalization.CultureInfo.GetCultureInfo("de-DE"));
    }
}