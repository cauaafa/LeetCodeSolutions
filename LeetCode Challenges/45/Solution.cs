public class Solution {
    public int Jump(int[] nums) {
        int res = 0;
        int cur = 0;
        int longest = 0;
        
        for (int i = 0; i < nums.Length - 1; i++) {
            longest = Math.Max(longest, i + nums[i]);
            if (i == cur) {
                res++;
                cur = longest;
            }
        }
        return res;
    }
}