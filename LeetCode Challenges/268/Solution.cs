public class Solution {
    public int MissingNumber(int[] nums) {
        int sum = 0, i = 0;
        int val = (nums.Length * (nums.Length + 1)) / 2;
        for (i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }
        return val - sum;
    }
}