namespace Solutions;

public class JumpGame
{
    public static bool CanJump(int[] nums)
    {
        var maxReach = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > maxReach) return false;
            maxReach = Math.Max(maxReach, i + nums[i]);
            if (maxReach >= nums.Length - 1) return true;
        }

        return true;
    }
}
