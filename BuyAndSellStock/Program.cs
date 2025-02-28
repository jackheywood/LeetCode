using BuyAndSellStock;

int[][] testPrices =
[
    new[] { 7, 1, 5, 3, 6, 4 },
    new[] { 1, 2, 3, 4, 5 },
    new[] { 7, 6, 4, 3, 1 },
];

var profits1 = testPrices.Select(Solution.MaxProfit1);
var profits2 = testPrices.Select(Solution.MaxProfit2);

Console.WriteLine("Solution 1:");

foreach (var profit in profits1)
{
    Console.WriteLine(profit);
}

Console.WriteLine("\nSolution 2:");

foreach (var profit in profits2)
{
    Console.WriteLine(profit);
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
