public static class Fehlerbehandlung
{
    public static void NegativeWerte(double wert, string paramName)
    {
        if (wert <= 0)
            throw new ArgumentOutOfRangeException(paramName, "Wert muss positiv sein.");
    }
}