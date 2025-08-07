namespace TicTacToe.Test;

public class UnitTest1
{
    [Fact]
    public void InitialisiereSpielfeld_Test()
    {
        // Arrange
        var spielfeld = new NeuesSpiel();

        // Act
        spielfeld.InitialisiereSpielfeld();

        // Assert
        Assert.Equal(" ", spielfeld.GetFeldInhalt(0));
        Assert.Equal(" ", spielfeld.GetFeldInhalt(1));
        Assert.Equal(" ", spielfeld.GetFeldInhalt(2));
        Assert.Equal(" ", spielfeld.GetFeldInhalt(3));
        Assert.Equal(" ", spielfeld.GetFeldInhalt(4));
        Assert.Equal(" ", spielfeld.GetFeldInhalt(5));
        Assert.Equal(" ", spielfeld.GetFeldInhalt(6));
        Assert.Equal(" ", spielfeld.GetFeldInhalt(7));
        Assert.Equal(" ", spielfeld.GetFeldInhalt(8));
    }

    [Theory]
    [InlineData(2, "X")]
    [InlineData(5, "O")]
    public void SetFeldInhalt_Test(int index, string value)
    {
        // Arrange
        var spielfeld = new NeuesSpiel();

        // Act
        spielfeld.InitialisiereSpielfeld();
        spielfeld.SetFeldInhalt(index, value);

        // Assert
        Assert.Equal(value, spielfeld.GetFeldInhalt(index));
    }
}
