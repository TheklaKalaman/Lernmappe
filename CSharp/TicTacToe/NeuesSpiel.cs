public class NeuesSpiel : ISpielfeld
{
    private string[] spielfeld;

    public NeuesSpiel()
    {
        spielfeld = new string[9];
    }
    public void InitialisiereSpielfeld()
    {
        for (int i = 0; i < spielfeld.Length; i++)
        {
            spielfeld[i] = " ";
        }
    }

    public string GetFeldInhalt(int index)
    {
        return spielfeld[index];
    }

    public void SetFeldInhalt(int index, string xo)
    {
        spielfeld[index] = xo;
    }
}