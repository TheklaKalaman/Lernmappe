namespace FizzBuzz.Test;

public class UnitTest1
{
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void FizzBuzzLogik_WithDivisbleBy3_ReturnFizz(int number)
    {
        // Arrange
        var logik = new FizzBuzzLogik();

        // Act
        var result = logik.ReturnLogik(number);

        // Assert
        Assert.Equal("Fizz!", result);
    }

    [Theory]
    [InlineData("42", 42)]
    // [InlineData("a")]
    // [InlineData("")]
    // [InlineData("-4")]
    public void Test1(string input, int expected)
    {
        // Arrange
        TextReader reader = new StringReader(input);
        TextWriter writer = new StringWriter();
        FizzBuzzy fizzBuzzy = new FizzBuzzy(reader, writer);

        // Act
        int number = fizzBuzzy.FizzBuzzInput();

        // Assert
        Assert.Equal(expected, number);

    }

    [Theory]
    [InlineData(42)]
    // [InlineData("a")]
    // [InlineData("")]
    // [InlineData("-4")]
    public void Test2(int input)
    {
        // Arrange
        //TextReader reader = null;
        TextWriter writer = new StringWriter();
        FizzBuzzy fizzBuzzy = new FizzBuzzy(null, writer);

        // Act
        fizzBuzzy.FizzBuzzCounter(input);
        string? text = writer.ToString();
    }
}
