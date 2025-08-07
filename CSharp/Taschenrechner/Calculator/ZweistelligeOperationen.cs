public abstract class ZweistelligeOperationen : IOperationen
{
    protected IOperationen links;
    protected IOperationen rechts;

    public ZweistelligeOperationen(IOperationen links, IOperationen rechts)
    {
        this.links = links;
        this.rechts = rechts;
    }

    public abstract double Auswerten();
}