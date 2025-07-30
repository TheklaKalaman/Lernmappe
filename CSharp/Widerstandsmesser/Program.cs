using Widerstaende;
internal class Program
{
    private static void Main(string[] args)
    {
        string farbe1 = "Rot";
        string farbe2 = "Braun";
        string farbe3 = "Silber";
        string farbe4 = "Grau";

        double testWiderstand = Widerstaende.Widerstaende.BerechneWiderstandOhneToleranz(
            farbe1, farbe2, farbe3);
        Console.WriteLine(testWiderstand);
        Console.WriteLine(21 * 0.01);

        double testToleranz = Widerstaende.Widerstaende.BerechneMaximumDesWiderstands(
            farbe1, farbe2, farbe3, farbe4);

        Console.WriteLine(testToleranz);
        Console.WriteLine(21 * 0.01 + (21 * 0.01 * 0.0005));
    }
}