namespace JumpGame;

internal class Solution
{
    // Too slow
    internal static bool CanJumpRecursive(int[] nums)
    {
        var jumpLength = nums[0];

        if (jumpLength >= nums.Length - 1)
        {
            return true;
        }

        for (var i = jumpLength; i > 0; i--)
        {
            if (CanJumpRecursive(nums[i..])) return true;
        }

        return false;
    }

    // Faster, but doesn't work...
    internal static bool CanJumpGreedy(int[] nums)
    {
        var jumpLength = nums[0];

        if (jumpLength >= nums.Length - 1)
        {
            return true;
        }

        var maxJump = 0;
        var maxIndex = 0;

        for (var i = 1; i <= jumpLength; i++)
        {
            if (nums[i] <= maxJump) continue;
            maxJump = nums[i];
            maxIndex = i;
        }

        return maxJump != 0 && CanJumpGreedy(nums[maxIndex..]);
    }

    internal static bool CanJumpGreedyRecursive(int[] nums)
    {
        var jumpLength = nums[0];

        if (jumpLength >= nums.Length - 1)
        {
            return true;
        }

        var possibleJumps = Enumerable.Range(1, jumpLength);
        var orderedJumps = possibleJumps.OrderByDescending(j => nums[j]).ToList();

        foreach (var jump in orderedJumps)
        {
            if (CanJumpGreedyRecursive(nums[jump..])) return true;
        }

        return false;
    }
}
