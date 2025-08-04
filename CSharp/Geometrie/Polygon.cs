public class Polygon
{
    private int AnzahlEcken;
    private double Seitenlaenge;
    public double Flaecheninhalt => AnzahlEcken * Seitenlaenge * Seitenlaenge / 4 * (Math.Tan(Math.PI / AnzahlEcken) / 1);
    public double Umfang => Seitenlaenge * AnzahlEcken;

    public Polygon(int anzahlEcken, double seitenlaenge)
    {
        AnzahlEcken = anzahlEcken;
        Seitenlaenge = seitenlaenge;
    }
}