namespace Widerstaende;

public class Ringe
{
    public record Widerstand(
        string Farbe,
        int Zehner,
        int Einer,
        double Multiplikator,
        double Toleranz);

    public static readonly List<Widerstand> Alle = new()
    {
        new("Silber", 0, 0, 0.01, 0.1),
        new("Gold", 0, 0, 0.1, 0.05),
        new("Schwarz", 0, 0, 1, 0),
        new("Braun", 1, 1, 10, 0.01),
        new("Rot", 2, 2, 100, 0.02),
        new("Orange", 3, 3, 1000, 0),
        new("Gelb", 4, 4, 10000, 0),
        new("Grün", 5, 5, 100000, 0.005),
        new("Blau", 6, 6, 100000, 0.0025),
        new("Violett", 7, 7, 10000000, 0.001),
        new("Grau", 8, 8, 100000000, 0.0005),
        new("Weiß", 9, 9, 1000000000, 0)
    };

    public static int KombiniereRing1UndRing2(
        int Ring1,
        int Ring2) =>
            Ring1 * 10 + Ring2;

    public static Widerstand WaehleRingAus(string farbe) =>
        Ringe.Alle.First(w => w.Farbe == farbe);

    public static int WaehleZehnerAus(string farbe) =>
        WaehleRingAus(farbe).Zehner;

    public static int WaehleEinerAus(string farbe) =>
        WaehleRingAus(farbe).Einer;

    public static double WaehleMultiplikatorAus(string farbe) =>
        WaehleRingAus(farbe).Multiplikator;

    public static double WaehleToleranzAus(string farbe) =>
        WaehleRingAus(farbe).Toleranz;
}