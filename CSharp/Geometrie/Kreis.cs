public class Kreis : IGeometrie
{
    private double Radius;
    public double Durchmesser => 2 * Radius;
    public double Umfang => 2 * Radius * Math.PI;
    public double Flaecheninhalt => Radius * Radius * Math.PI;

    public Kreis(double radius)
    {
        Radius = radius;
    }

     
}