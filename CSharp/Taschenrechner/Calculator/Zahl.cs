public class Zahl : IOperationen
{
    private double wert;

    public Zahl(double wert)
    {
        this.wert = wert;
    }

    public double Auswerten()
    {
        return wert;
    }
}