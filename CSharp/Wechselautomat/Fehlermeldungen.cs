namespace Wechselautomat;

public static class Fehlermeldungen
{
    public static readonly string BetragNegativOderNull =
        "Betrag darf nicht negativ oder 0 sein.";
    public static readonly string FalschesFormat =
        "Fehler: Ungültiges Format. Bitte geben Sie einen gültigen Betrag ein.";
    public static readonly string BetragIstNull =
        "Preis und bezahlter Betrag dürfen nicht null sein.";
    public static readonly string BetragIstNegativOderNull =
        "Preis und bezahlter Betrag dürfen nicht negativ oder 0 sein.";
    public static readonly string UnerwarteterFehler =
        "Ein unerwarteter Fehler ist aufgetreten: ";
}