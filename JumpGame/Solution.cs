namespace JumpGame;

internal class Solution
{
    internal static bool CanJump(int[] nums)
    {
        var i = 0;
        var maxReach = 0;

        while (i < nums.Length && i <= maxReach)
        {
            maxReach = Math.Max(maxReach, i + nums[i]);
            if (maxReach == nums.Length) return true;
            i++;
        }

        return i == nums.Length;
    }
}
