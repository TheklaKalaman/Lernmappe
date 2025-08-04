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
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(a, nameof(a));
        SeiteA = a;

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(b, nameof(b));
        SeiteB = b;

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(c, nameof(c));
        SeiteC = c;

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(hoehe, nameof(hoehe));
        Hoehe = hoehe;
    }
}