namespace BuyAndSellStock;

internal class Solution
{
    public static int MaxProfit1(int[] prices)
    {
        var totalProfit = 0;
        var profit = 0;
        var bought = prices[0];
        var sold = 0;

        foreach (var price in prices)
        {
            if (price < bought)
            {
                bought = price;
                sold = price;
            }

            if (price > sold)
            {
                sold = price;
            }

            var currentProfit = price - bought;

            if (currentProfit > profit)
            {
                profit = currentProfit;
            }

            if (currentProfit < profit)
            {
                totalProfit += profit;
                bought = price;
                sold = price;
                profit = 0;
            }
        }

        return totalProfit + profit;
    }

    public static int MaxProfit2(int[] prices)
    {
        var profit = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                profit += prices[i] - prices[i - 1];
            }
        }

        return profit;
    }
}
