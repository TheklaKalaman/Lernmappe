public class Quadrat : IGeometrie
{
    private double Seitenlaenge { get; set; }
    public double Flaecheninhalt => Seitenlaenge * Seitenlaenge;
    public double Umfang => 4 * Seitenlaenge;

    public Quadrat(double seitenlaenge)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(seitenlaenge, nameof(seitenlaenge));
        Seitenlaenge = seitenlaenge;
    }
    
    
}