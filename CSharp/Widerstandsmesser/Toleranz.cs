namespace Widerstaende;

public static class Toleranz
{
    public static double Streuung(
        string zehner,
        string einer,
        string multiplikator,
        string toleranz) =>
        Widerstaende.BerechneWiderstandOhneToleranz(
            zehner, einer, multiplikator) * Ringe.WaehleToleranzAus(toleranz);

    public static double Minimum(
        string zehner,
        string einer,
        string multiplikator,
        string toleranz) =>
        Widerstaende.BerechneWiderstandOhneToleranz(
            zehner, einer, multiplikator)
            - Streuung(zehner, einer, multiplikator, toleranz);

    public static double Maximum(
        string zehner,
        string einer,
        string multiplikator,
        string toleranz) =>
        Widerstaende.BerechneWiderstandOhneToleranz(
            zehner, einer, multiplikator)
            + Streuung(zehner, einer, multiplikator, toleranz);
}