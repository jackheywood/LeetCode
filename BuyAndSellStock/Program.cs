using BuyAndSellStock;
using Helpers;

// You are given an integer array prices where prices[i] is the price of a given
// stock on the ith day.
//
// On each day, you may decide to buy and/or sell the stock. You can only hold
// at most one share of the stock at any time. However, you can buy it then 
// immediately sell it on the same day.
//
// Find and return the maximum profit you can achieve.

int[][] testPrices =
[
    [7, 1, 5, 3, 6, 4],
    [1, 2, 3, 4, 5],
    [7, 6, 4, 3, 1],
];

var profits1 = testPrices.Select(Solution.MaxProfit1).ToList();
var profits2 = testPrices.Select(Solution.MaxProfit2).ToList();

WriteSolution(1, profits1);
WriteSolution(2, profits2);

ConsoleHelpers.WriteExit();

return;

void WriteSolution(int solutionId, List<int> profits)
{
    Console.WriteLine($"==== Solution {solutionId} ====\n");

    for (var i = 0; i < testPrices.Length; i++)
    {
        Console.WriteLine($"Test data: [{string.Join(", ", testPrices[i])}]");
        Console.WriteLine($"Max profit: {profits[i]}\n");
    }

    Console.WriteLine();
}
