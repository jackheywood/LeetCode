using System.Diagnostics;
using Solutions;

namespace Tests;

public class JumpGameTests
{
    [Fact]
    public void CanJump_WithSolution_ReturnsTrue()
    {
        // Arrange
        int[] nums = [2, 3, 1, 1, 4];

        // Act
        var result = JumpGame.CanJump(nums);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void CanJump_WithoutSolution_ReturnsFalse()
    {
        // Arrange
        int[] nums = [3, 2, 1, 0, 4];

        // Act
        var result = JumpGame.CanJump(nums);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void CanJump_LongArray_CompletesQuickly()
    {
        // Arrange
        int[] inputSizes = [100, 10000, 20000, 30000, 40000];
        var inputs = inputSizes.Select(GenerateRandomNumsWithSolution).ToArray();

        var times = new double[inputSizes.Length];

        // Act
        for (var i = 0; i < inputSizes.Length; i++)
        {
            var sw = Stopwatch.StartNew();
            JumpGame.CanJump(inputs[i]);
            sw.Stop();
            times[i] = sw.Elapsed.TotalMilliseconds;
        }

        // Assert
        for (var i = 2; i < times.Length; i++) // Discard first result to account for JIT
        {
            var ratio = times[i] / times[i - 1];
            var expectedRatio = (double)inputSizes[i] / inputSizes[i - 1];

            Assert.InRange(ratio, expectedRatio * 0.5, expectedRatio * 1.5);
        }
    }

    private static int[] GenerateRandomNumsWithSolution(int size)
    {
        var rand = new Random();
        var nums = new int[size];

        for (var i = 0; i < size; i++)
        {
            nums[i] = rand.Next(1, 5);
        }

        return nums;
    }
}
