public class Parallelogramm
{
    private double Grundseite;
    private double Hoehe;
    public double Flaecheninhalt => Grundseite * Hoehe;
    public double Umfang => 2 * (Grundseite + Hoehe);

    public Parallelogramm(double grundseite, double hoehe)
    {
        Grundseite = grundseite;
        Hoehe = hoehe;
    }
}