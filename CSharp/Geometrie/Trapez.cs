public class Trapez : IGeometrie
{
    private double Hoehe;
    private double SeiteA;
    private double SeiteC;
    public double Flaecheninhalt => (SeiteA + SeiteC) / 2 * Hoehe;
    public double Umfang => 2 * Hoehe + SeiteA + SeiteC;

    public Trapez(double hoehe, double a, double c)
    {
        Fehlerbehandlung.NegativeWerte(hoehe, nameof(hoehe));
        Hoehe = hoehe;

        Fehlerbehandlung.NegativeWerte(a, nameof(a));
        SeiteA = a;

        Fehlerbehandlung.NegativeWerte(c, nameof(c));
        SeiteC = c;
    }
}