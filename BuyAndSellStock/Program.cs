using BuyAndSellStock;

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

WriteExit();

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

void WriteExit()
{
    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
}
