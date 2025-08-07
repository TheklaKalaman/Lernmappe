public class Multiplikation : ZweistelligeOperationen
{
    public Multiplikation(IOperationen links, IOperationen rechts) : base(links, rechts)
    {
    }

    public override double Auswerten()
    {
        return links.Auswerten() * rechts.Auswerten();
    }
}