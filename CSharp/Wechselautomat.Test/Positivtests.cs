namespace Wechselautomat.Test;

public class Positivtests
{
    private EuroUndCents.Geldstueck GetGeldstueck(decimal wert)
        => EuroUndCents.Alle.First(g => g.Wert == wert);

    [Fact]
    public void InScheineUndMuenzenZerlegen_EinfacherBetrag()
    {
        decimal betrag = 5m;
        var result = GeldZerleger.InScheineUndMuenzenZerlegen(betrag);

        var fuenfEuro = GetGeldstueck(5m);

        Assert.True(result.ContainsKey(fuenfEuro));
        Assert.Equal(1, result[fuenfEuro]);
        Assert.Single(result);
    }

    [Fact]
    public void InScheineUndMuenzenZerlegen_ZweiStuecke()
    {
        decimal betrag = 7m;
        var result = GeldZerleger.InScheineUndMuenzenZerlegen(betrag);

        var fuenfEuro = GetGeldstueck(5m);
        var zweiEuro = GetGeldstueck(2m);

        Assert.Equal(1, result[fuenfEuro]);
        Assert.Equal(1, result[zweiEuro]);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void FormatierungDesWechselgeldTexts_EinCent()
    {
        var einCent = GetGeldstueck(0.01m);
        var dict = new Dictionary<EuroUndCents.Geldstueck, int>
        {
            { einCent, 1 }
        };

        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);

        Assert.Equal("1 x 1 Cent Münze", result);
    }

    [Fact]
    public void FormatierungDesWechselgeldTexts_EinCentUndEinEuro()
    {
        var einEuro = GetGeldstueck(1m);
        var einCent = GetGeldstueck(0.01m);

        var dict = new Dictionary<EuroUndCents.Geldstueck, int>
        {
            { einEuro, 1 },
            { einCent, 1 }
        };

        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);

        Assert.Equal("1 x 1 Euro Schein\n1 x 1 Cent Münze", result);
    }

    [Fact]
    public void FormatierungDesWechselgeldTexts_ZweiZwanzigCent()
    {
        var zwanzigCent = GetGeldstueck(0.20m);
        var dict = new Dictionary<EuroUndCents.Geldstueck, int>
        {
            { zwanzigCent, 2 }
        };

        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);

        Assert.Equal("2 x 20 Cent Münzen", result);
    }

    [Fact]
    public void FormatierungDesWechselgeldTexts_VieleStuecke()
    {
        var dict = new Dictionary<EuroUndCents.Geldstueck, int>
        {
            { GetGeldstueck(5m), 1 },
            { GetGeldstueck(2m), 1 },
            { GetGeldstueck(0.50m), 1 },
            { GetGeldstueck(0.20m), 2 },
            { GetGeldstueck(0.01m), 3 }
        };

        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);

        string erwartung = "1 x 5 Euro Schein\n" +
                                  "1 x 2 Euro Schein\n" +
                                  "1 x 50 Cent Münze\n" +
                                  "2 x 20 Cent Münzen\n" +
                                  "3 x 1 Cent Münzen";

        Assert.Equal(erwartung, result);
    }

    [Fact]
    public void EdgeCase_KeinWechselgeld()
    {
        var dict = new Dictionary<EuroUndCents.Geldstueck, int>();
        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);
        Assert.Equal(string.Empty, result);
    }

    [Theory]
    [InlineData(9.50, 10.00)]
    [InlineData(20.00, 50.00)]
    [InlineData(0.99, 1.00)]
    [InlineData(1.23, 2.00)]
    [InlineData(5.75, 10.00)]
    public void PreisWirdGenannt_BetragWirdBezahltUndAbgezogen(decimal preis, decimal bezahlt)
    {
        var expected = bezahlt - preis;
        decimal wechselgeld = Bezahlvorgang.BerechneWechselgeld(preis, bezahlt);
        Assert.Equal(expected, wechselgeld);
    }

    [Fact]
    public void GibEuroWertOhneTrennzeichenEin_WandleInGeldwertUm()
    {
        decimal wert = 5;
        Assert.Equal("5 Euro", Geldwert.Bezeichnung(wert));
    }
}
