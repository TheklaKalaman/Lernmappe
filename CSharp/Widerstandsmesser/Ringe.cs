namespace Widerstaende;

public class Ring
{
    public Farben Farbe { get; }
    public int Zehner { get; }
    public int Einer { get; }
    public double Multiplikator { get; }
    public double Toleranz { get; }

    public Ring(Farben farbe, int zehner, int einer, double multiplikator, double toleranz)
    {
        Farbe = farbe;
        Zehner = zehner;
        Einer = einer;
        Multiplikator = multiplikator;
        Toleranz = toleranz;
    }

    public static readonly Ring Silber = new(Farben.Silber, 0, 0, 0.01, 10);
    public static readonly Ring Gold = new(Farben.Gold, 0, 0, 0.1, 5);
    public static readonly Ring Schwarz = new(Farben.Schwarz, 0, 0, 1, 0);
    public static readonly Ring Braun = new(Farben.Braun, 0, 0, 10, 1);
    public static readonly Ring Rot = new(Farben.Rot, 2, 2, 100, 2);
    public static readonly Ring Orange = new(Farben.Orange, 3, 3, 1000, 0);
    public static readonly Ring Gelb = new(Farben.Gelb, 4, 4, 10000, 0);
    public static readonly Ring Grün = new(Farben.Grün, 5, 5, 100000, 0.5);
    public static readonly Ring Blau = new(Farben.Blau, 6, 6, 1000000, 0.25);
    public static readonly Ring Violett = new(Farben.Violett, 7, 7, 10000000, 0.1);
    public static readonly Ring Grau = new(Farben.Gold, 8, 8, 100000000, 0.05);
    public static readonly Ring Weiß = new(Farben.Gold, 9, 9, 1000000000, 0);

    public enum Farben
    {
        Silber = -2,
        Gold,
        Schwarz,
        Braun,
        Rot,
        Orange,
        Gelb,
        Grün,
        Blau,
        Violett,
        Grau,
        Weiß
    }

}

// {
//     public record Widerstand(
//         string Farbe,
//         int Zehner,
//         int Einer,
//         double Multiplikator,
//         double Toleranz);

//     public static readonly List<Widerstand> Alle = new()
//     {
//         new("Silber", 0, 0, 0.01, 0.1),
//         new("Gold", 0, 0, 0.1, 0.05),
//         new("Schwarz", 0, 0, 1, 0),
//         new("Braun", 1, 1, 10, 0.01),
//         new("Rot", 2, 2, 100, 0.02),
//         new("Orange", 3, 3, 1000, 0),
//         new("Gelb", 4, 4, 10000, 0),
//         new("Grün", 5, 5, 100000, 0.005),
//         new("Blau", 6, 6, 100000, 0.0025),
//         new("Violett", 7, 7, 10000000, 0.001),
//         new("Grau", 8, 8, 100000000, 0.0005),
//         new("Weiß", 9, 9, 1000000000, 0)
//     };

//     public int KombiniereRing1UndRing2(
//         int Ring1,
//         int Ring2) =>
//             Ring1 * 10 + Ring2;

//     public Widerstand WaehleRingAus(string farbe) =>
//         Ringe.Alle.First(w => w.Farbe == farbe);

//     public int WaehleZehnerAus(string farbe) =>
//         WaehleRingAus(farbe).Zehner;

//     public int WaehleEinerAus(string farbe) =>
//         WaehleRingAus(farbe).Einer;

//     public double WaehleMultiplikatorAus(string farbe) =>
//         WaehleRingAus(farbe).Multiplikator;

//     public double WaehleToleranzAus(string farbe) =>
//         WaehleRingAus(farbe).Toleranz;
// }