public abstract class EinstelligeOperationen : IOperationen
{
    protected IOperationen operand;

    public EinstelligeOperationen(IOperationen operand)
    {
        this.operand = operand;
    }

    public abstract double Auswerten();
}