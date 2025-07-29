namespace Wechselautomat;

public class Geldwert
{
    public decimal Wert { get; }

    public Geldwert(decimal wert)
    {
        Wert = wert;
    }

    public static string Bezeichnung(decimal wert)
    {
        int euroWert = (int)wert;
        int centWert = (int)((wert - Math.Truncate(wert)) * 100 + 0.5m);

        string euroTeil = euroWert == 0 ? ""
            : euroWert == 1 ? "1 Euro"
            : $"{euroWert} Euro";

        string centTeil = centWert == 0 ? ""
            : centWert == 1 ? "1 Cent"
            : $"{centWert} Cent";

        if (euroWert > 0 && centWert > 0)
            return $"{euroTeil}, {centTeil}";
        if (euroWert > 0)
            return euroTeil;
        if (centWert > 0)
            return centTeil;
        
        return "0 Euro";
    }
}