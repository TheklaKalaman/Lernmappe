namespace Wechselautomat;

public static class EuroUndCents
{
    public record Geldstueck(decimal Wert, string Bezeichnung, bool IstSchein);

    public static readonly List<Geldstueck> Alle = new()
    {
        new(200, "200 Euro", true),
        new(100, "100 Euro", true),
        new(50, "50 Euro", true),
        new(20, "20 Euro", true),
        new(10, "10 Euro", true),
        new(5, "5 Euro", true),
        new(2, "2 Euro", false),
        new(1, "1 Euro", false),
        new(0.50m, "50 Cent", false),
        new(0.20m, "20 Cent", false),
        new(0.10m, "10 Cent", false),
        new(0.05m, "5 Cent", false),
        new(0.02m, "2 Cent", false),
        new(0.01m, "1 Cent", false)
    };
}

//     [
//         500m, 200m, 100m, 50m, 20m, 10m, 5m, 2m, 1m,
//         0.50m, 0.20m, 0.10m, 0.05m, 0.02m, 0.01m
//     ];
// }