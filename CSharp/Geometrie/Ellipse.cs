public class Ellipse : IGeometrie
{
    private double grosseHalbachse;
    private double kleineHalbachse;
    public double Flaecheninhalt => Math.PI * grosseHalbachse * kleineHalbachse;
    public double Umfang => RamanujanFormel();

    public Ellipse(double a, double b)
    {
        grosseHalbachse = a;
        kleineHalbachse = b;
    }

    private double RamanujanFormel() =>
        Math.PI * 3 * (grosseHalbachse * kleineHalbachse) -
            Math.Sqrt((3 * grosseHalbachse + kleineHalbachse) * (grosseHalbachse + 3 * kleineHalbachse));
}