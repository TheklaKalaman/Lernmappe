public class Dreieck : IGeometrie
{
    private double SeiteA;
    private double SeiteB;
    private double SeiteC;
    private double Hoehe;
    public double Flaecheninhalt => SeiteA * Hoehe / 2;
    public double Umfang => SeiteA + SeiteB + SeiteC;

    public Dreieck(double a, double b, double c, double hoehe)
    {
        Fehlerbehandlung.NegativeWerte(a, nameof(a));
        SeiteA = a;

        Fehlerbehandlung.NegativeWerte(b, nameof(b));
        SeiteB = b;

        Fehlerbehandlung.NegativeWerte(c, nameof(c));
        SeiteC = c;

        Fehlerbehandlung.NegativeWerte(hoehe, nameof(hoehe));
        Hoehe = hoehe;
    }
}