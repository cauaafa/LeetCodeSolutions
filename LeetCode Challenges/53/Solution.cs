public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSub = nums[0];
        int curSub = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            curSub = Math.Max(nums[i], curSub + nums[i]);
            maxSub = Math.Max(maxSub, curSub);
        }

        return maxSub;
    }
}