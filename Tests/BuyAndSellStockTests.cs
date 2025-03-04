using Solutions;

namespace Tests;

public class BuyAndSellStockTests
{
    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { (int[]) [7, 1, 5, 3, 6, 4], 7 },
            new object[] { (int[]) [1, 2, 3, 4, 5], 4 },
            new object[] { (int[]) [7, 6, 4, 3, 1], 0 },
        };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxProfit1_ReturnsExpectedProfit(int[] prices, int expectedProfit)
    {
        // Act
        var profit = BuyAndSellStock.MaxProfit1(prices);

        // Assert
        Assert.Equal(expectedProfit, profit);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxProfit2_ReturnsExpectedProfit(int[] prices, int expectedProfit)
    {
        // Act
        var profit = BuyAndSellStock.MaxProfit2(prices);

        // Assert
        Assert.Equal(expectedProfit, profit);
    }
}
