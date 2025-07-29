namespace Wechselautomat;

using System.Linq;

public class GeldFormatierer
{
    public static string? FormatierungDesWechselgeldTexts(Dictionary<EuroUndCents.Geldstueck, int> dict)
        => string.Join('\n', dict
                .OrderByDescending(x => x.Key.Wert)
                .Select(x => $"{x.Value} x {x.Key.Bezeichnung} " +
                        (x.Key.IstSchein
                            ? (x.Value == 1 ? "Schein" : "Scheine")
                            : (x.Value == 1 ? "Münze" : "Münzen"))));

    public static decimal ParseBetrag(string eingabe)
    {
        string? normiert = eingabe.Replace('.', ',');
        return decimal.Parse(normiert, System.Globalization.CultureInfo.GetCultureInfo("de-DE"));
    }
}