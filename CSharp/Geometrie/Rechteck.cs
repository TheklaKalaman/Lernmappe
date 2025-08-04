public class Rechteck : IGeometrie
{
    private double Hoehe;
    private double Breite;
    public double Flaecheninhalt => Hoehe * Breite;
    public double Umfang => 2 * Hoehe + 2 * Breite;

    public Rechteck(double hoehe, double breite)
    {
        Fehlerbehandlung.NegativeWerte(hoehe, nameof(hoehe));
        Hoehe = hoehe;

        Fehlerbehandlung.NegativeWerte(breite, nameof(breite));
        Breite = breite;
    }
}