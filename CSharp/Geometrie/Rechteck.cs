public class Rechteck : IGeometrie
{
    private double Hoehe;
    private double Breite;
    public double Flaecheninhalt => Hoehe * Breite;
    public double Umfang => 2 * Hoehe + 2 * Breite;

    public Rechteck(double hoehe, double breite)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(hoehe, nameof(hoehe));
        Hoehe = hoehe;

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(breite, nameof(breite));
        Breite = breite;
    }
}