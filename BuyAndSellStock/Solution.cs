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
                // Set new lowest price
                bought = price;
                sold = price;
            }

            if (price > sold)
            {
                // Set new highest price
                sold = price;
            }

            var currentProfit = price - bought;

            // Check if this makes us more profit
            if (currentProfit > profit)
            {
                profit = currentProfit;
            }

            if (currentProfit < profit)
            {
                // Sell at previous highest profit and reset
                totalProfit += profit;
                bought = price;
                sold = price;
                profit = 0;
            }
        }

        // Sell up any remaining stock
        totalProfit += profit;

        return totalProfit;
    }

    public static int MaxProfit2(int[] prices)
    {
        var profit = 0;

        // Always selling and buying again if the price is higher on the
        // next day is equivalent to buying low and selling high!
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
