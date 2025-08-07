public class Wurzel : EinstelligeOperationen
{
    public Wurzel(IOperationen operand) : base(operand)
    {
    }

    public override double Auswerten()
    {
        double wert = operand.Auswerten();
        if (wert < 0)
        {
            throw new InvalidOperationException("Die Wurzel aus einer negativen Zahl ist nicht definiert.");
        }
        return Math.Sqrt(wert);
    }
}