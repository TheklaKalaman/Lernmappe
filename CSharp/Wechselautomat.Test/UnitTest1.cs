using System.Runtime.InteropServices;

namespace Wechselautomat.Test;

public class UnitTest1
{
    [Theory]
    [InlineData("2,22", "2 Euro, 22 Cent")]
    [InlineData("3,46", "3 Euro, 46 Cent")]
    public void AutomatNimmtBetragEntgegen_GibtStringZurueck(String eingabe, String erwartung)
    {
        var rueckgabe = Wechselautomat.Start(eingabe);
        Assert.Equal(erwartung, rueckgabe);
    }

    [Theory]
    [InlineData(2.34)]
    [InlineData(0.01)]
    [InlineData(3.46)]
    [InlineData(3536.34)]
    public void GeldwertWirdEingegeben_GeldwertObjektKommtRaus(decimal wert)
    {
        string geldwert = Geldwert.Bezeichnung(wert);
        Assert.Equal(Geldwert.Bezeichnung(wert), geldwert);
    }

    [Fact]
    public void InScheineUndMuenzenZerlegen_EinfacherBetrag()
    {
        decimal betrag = 5m;
        var result = GeldZerleger.InScheineUndMuenzenZerlegen(betrag);
        Assert.True(result.ContainsKey(5m));
        Assert.Equal(1, result[5m]);
        Assert.Single(result);
    }

    [Fact]
    public void InScheineUndMuenzenZerlegen_ZweiStuecke()
    {
        decimal betrag = 7m;
        var result = GeldZerleger.InScheineUndMuenzenZerlegen(betrag);

        Assert.Equal(1, result[5m]);
        Assert.Equal(1, result[2m]);
        Assert.Equal(2, result.Count);
    }

    [Fact]
    public void FormatierungDesWechselgeldTexts_EinCent()
    {
        var dict = new Dictionary<decimal, int>
        {
            { 0.01m, 1 }
        };

        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);

        Assert.Equal("1 x 1 Cent Münze", result);
    }

    [Fact]
    public void FormatierungDesWechselgeldTexts_EinCentUndEinEuro()
    {
        var dict = new Dictionary<decimal, int>
        {
            { 1m, 1 },
            { 0.01m, 1 }
        };

        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);

        Assert.Equal("1 x 1 Euro Schein\n1 x 1 Cent Münze", result);
    }

    [Fact]
    public void FormatierungDesWechselgeldTexts_ZweiZwanzigCent()
    {
        var dict = new Dictionary<decimal, int>
        {
            { 0.20m, 2 }
        };

        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);

        Assert.Equal("2 x 20 Cent Münzen", result);
    }

    [Fact]
    public void FormatierungDesWechselgeldTexts_VieleStuecke()
    {
        var dict = new Dictionary<decimal, int>
        {
            { 5m, 1 },
            { 2m, 1 },
            { 0.50m, 1 },
            { 0.20m, 2 },
            { 0.01m, 3 }
        };

        var result = GeldFormatierer.FormatierungDesWechselgeldTexts(dict);

        string erwartung = "1 x 5 Euro Schein\n" +
                                  "1 x 2 Euro Schein\n" +
                                  "1 x 50 Cent Münze\n" +
                                  "2 x 20 Cent Münzen\n" +
                                  "3 x 1 Cent Münzen";

        Assert.Equal(erwartung, result);
    }
}
