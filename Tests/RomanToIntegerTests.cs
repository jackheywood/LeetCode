using Solutions;

namespace Tests;

public class RomanToIntegerTests
{
    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { "III", 3 },
            new object[] { "LVIII", 58 },
            new object[] { "MCMXCIV", 1994 },
        };

    [Theory]
    [MemberData(nameof(TestData))]
    public void RomanToIntForward_ConvertsCorrectly(string numerals, int expected)
    {
        // Act
        var result = RomanToInteger.RomanToIntForward(numerals);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RomanToIntForward_EmptyString_ReturnsZero()
    {
        // Acr
        var result = RomanToInteger.RomanToIntForward("");

        // Assert
        Assert.Equal(0, result);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void RomanToIntReverse_ConvertsCorrectly(string numerals, int expected)
    {
        // Act
        var result = RomanToInteger.RomanToIntReverse(numerals);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void RomanToIntReverse_EmptyString_ReturnsZero()
    {
        // Acr
        var result = RomanToInteger.RomanToIntReverse("");

        // Assert
        Assert.Equal(0, result);
    }
}
