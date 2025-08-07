public class Negation : EinstelligeOperationen
{
    public Negation(IOperationen operand) : base(operand)
    {
    }

    public override double Auswerten()
    {
        return -operand.Auswerten();
    }
}