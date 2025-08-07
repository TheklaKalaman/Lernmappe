public class Subtraktion : ZweistelligeOperationen
{
    public Subtraktion(IOperationen links, IOperationen rechts) : base(links, rechts)
    {
    }

    public override double Auswerten()
    {
        return links.Auswerten() - rechts.Auswerten();
    }
}