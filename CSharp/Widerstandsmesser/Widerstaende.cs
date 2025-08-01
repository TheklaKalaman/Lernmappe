namespace Widerstaende;

public class Widerstand
{
    public Ring Farbe1 { get; }
    public Ring Farbe2 { get; }
    public Ring Farbe3 { get; }
    public Ring Farbe4 { get; }

    public Widerstand(Ring farbe1, Ring farbe2, Ring farbe3, Ring farbe4)
    {
        Farbe1 = farbe1;
        if (farbe1 == null)
            throw new Exception("Ungültige Farbe an erster Position.");
        Farbe2 = farbe2;
        if (farbe2 == null)
            throw new Exception("Ungültige Farbe an zweiter Position.");
        Farbe3 = farbe3;
        Farbe4 = farbe4;
        if (farbe4 == null)
            throw new Exception("Ungültige Farbe an vierter Position.");
    }
    public double? BerechneWiderstandOhneToleranz() =>
        (Farbe1.Zehner * 10 + Farbe2.Einer) * Farbe3.Multiplikator;

    public double? Toleranz() =>
        BerechneWiderstandOhneToleranz() * (Farbe4.Toleranz / 100);

    public double? Minimum() =>
        BerechneWiderstandOhneToleranz() - Toleranz();

    public double? Maximum() =>
        BerechneWiderstandOhneToleranz() + Toleranz();
}