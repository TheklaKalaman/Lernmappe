using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Widerstaende;
using Xunit.Sdk;

namespace Widerstandsmesser.Test;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 3)]
    [InlineData(4, 6)]
    [InlineData(9, 8)]
    [InlineData(8, 1)]
    public void NimmtZweiWerte_SetztBeideWerteZusammen(int x, int y)
    {
        var ring1Undring2 = Widerstaende.Ringe.KombiniereRing1UndRing2(x, y);
        Assert.Equal(x * 10 + y, ring1Undring2);
    }

    [Theory]
    [InlineData("Grün", "Grau", "Gold", "Violett")]
    public void NimmtEinenWert_BerechnetStreuung(
        string zehner, string einer, string multiplikator, string toleranz)
    {
        var beispielStreuung = Widerstaende.Toleranz.Streuung(zehner, einer, multiplikator, toleranz);
        var expected = (5 * 10 + 8) * 0.1 * 0.001;
        Assert.Equal(expected, beispielStreuung);
    }

    [Theory]
    [InlineData("Grün", "Grau", "Gold", "Violett")]
    public void NimmtEinenWert_BerechnetMinimum(
        string zehner, string einer, string multiplikator, string toleranz
    )
    {
        double minimum = Widerstaende.Toleranz.Minimum(zehner, einer, multiplikator, toleranz);
        double expected = (5 * 10 + 8) * 0.1 - ((5 * 10 + 8) * 0.1 * 0.001);

        Assert.Equal(expected, minimum);
    }

    [Theory]
    [InlineData("Grün", "Grau", "Gold", "Violett")]
    public void NimmtEinenWert_BerechnetMaximum(
        string zehner, string einer, string multiplikator, string toleranz
    )
    {
        double maximum = Widerstaende.Toleranz.Maximum(zehner, einer, multiplikator, toleranz);
        double expected = (5 * 10 + 8) * 0.1 + ((5 * 10 + 8) * 0.1 * 0.001);

        Assert.Equal(expected, maximum);
    }

    [Fact]
    public void NimmtEinenWert_BerechnetMinimumUndMaximum()
    {
        double beispielWert = 1225;
        double streuung = 0.05;
        double minimum = beispielWert - (beispielWert * streuung);
        double maximum = beispielWert + (beispielWert * streuung);

        Assert.Equal(1163.75, minimum);
        Assert.Equal(1286.25, maximum);
    }

    [Theory]
    [InlineData("Gelb")]
    [InlineData("Schwarz")]
    [InlineData("Weiß")]
    [InlineData("Braun")]
    public void NimmtFarbe_GibtWerteZurueck(string farbe)
    {
        var result = Ringe.Alle.Where(w => w.Farbe == farbe).ToList();

        Assert.NotEmpty(result);
        Assert.All(result, w => Assert.Equal(farbe, w.Farbe));
    }

    [Theory]
    [InlineData("Gelb")]
    [InlineData("Schwarz")]
    [InlineData("Weiß")]
    [InlineData("Braun")]

    public void NimmtFarbe_GibtZehnerZurueck(string farbe)
    {
        var ring = Ringe.Alle.First(w => w.Farbe == farbe);
        int zehner = ring.Zehner;

        Assert.Equal(ring.Zehner, zehner);
    }

    [Fact]
    public void NimmtFarbe_GibtMultiplikatorZurueck()
    {
        var rot = Ringe.WaehleRingAus("Rot");
        double multiplikator = rot.Multiplikator;

        Assert.Equal(100, multiplikator);
    }

    [Fact]
    public void NimmtFarbe_GibtToleranzZurueck()
    {
        var blau = Ringe.Alle.First(w => w.Farbe == "Blau");
        double toleranz = blau.Toleranz;

        Assert.Equal(0.0025, toleranz);
    }
}
