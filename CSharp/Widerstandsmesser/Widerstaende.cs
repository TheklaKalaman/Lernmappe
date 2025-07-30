namespace Widerstaende;

public static class Widerstaende
{
    public static double BerechneWiderstandOhneToleranz(
        string farbe1,
        string farbe2,
        string farbe3) =>

        Ringe.KombiniereRing1UndRing2(
            Ringe.WaehleZehnerAus(farbe1),
            Ringe.WaehleEinerAus(farbe2)) *
            Ringe.WaehleMultiplikatorAus(farbe3);

    public static double BerechneMaximumDesWiderstands(
        string farbe1,
        string farbe2,
        string farbe3,
        string farbe4) =>

        Toleranz.Maximum(farbe1, farbe2, farbe3, farbe4);

    public static double BerechneMinimumDesWiderstand(
        string farbe1,
        string farbe2,
        string farbe3,
        string farbe4) =>

        Toleranz.Minimum(farbe1, farbe2, farbe3, farbe4);
}