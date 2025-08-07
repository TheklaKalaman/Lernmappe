public interface ISpielfeld
{
    public void InitialisiereSpielfeld();
    public string GetFeldInhalt(int index);
    public void SetFeldInhalt(int index, string xo);
}