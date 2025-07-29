using Xunit.Sdk;

namespace Wechselautomat.Test;

public class Negativtests
{
    [Theory]
    [InlineData("-1", "5.00")]
    [InlineData("5.00", "-1")]
    [InlineData("-5.00", "-1")]
    public void EingabeNegativerWerte(string preis,string bezahlt)
    {
        Assert.Throws<ArgumentException>(() => Wechselautomat.Start(preis, bezahlt));
    }

    [Theory]
    [InlineData("abc", "5.00")]
    [InlineData("5.00", "xyz")]
    [InlineData("abc", "xyz")]
    [InlineData("5.00", "1.23abc")]
    public void EingabeNichtNumerischerWerte(string preis, string bezahlt)
    {
        Assert.Throws<FormatException>(() => Wechselautomat.Start(preis, bezahlt));
    }

    [Theory]
    [InlineData("0.00", "5.00")]
    [InlineData("5.00", "0.00")]
    [InlineData("0,00", "5,00")]
    [InlineData("5,00", "0,00")]
    [InlineData("0", "0")]
    public void EingabeNull(string preis, string bezahlt)
    {
        Assert.Throws<ArgumentException>(() => Wechselautomat.Start(preis, bezahlt));
    }
}