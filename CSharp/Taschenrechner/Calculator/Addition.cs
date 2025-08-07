public class Addition : ZweistelligeOperationen
{
    public Addition(IOperationen links, IOperationen rechts) : base(links, rechts)
    {
    }

    public override double Auswerten()
    {
        return links.Auswerten() + rechts.Auswerten();
    }
}