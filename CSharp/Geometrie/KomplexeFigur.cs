public class KomplexeFigur
{
    private List<IGeometrie> figuren = new();
    public void Hinzufuegen(IGeometrie figur) =>
        figuren.Add(figur);
    public double Flaecheninhalt =>
        figuren.Sum(f => f.Flaecheninhalt);
}