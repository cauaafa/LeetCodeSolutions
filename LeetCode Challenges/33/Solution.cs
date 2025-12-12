public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 1) return target == nums[0] ? 0 : -1;

        int i = nums.Length - 1;
        while (i > 0) {
            if (nums[i] < nums[i - 1]) {
                break;
            }
            i--;
        }

        int l = 0;
        int r = nums.Length - 1;

        while (l <= r) {
            int m = l + (r - l) / 2;
            if (nums[Index(m, i, nums.Length)] == target) {
                return Index(m, i, nums.Length);
            }
            if (nums[Index(m, i, nums.Length)] > target) {
                r = m - 1;
            } else {
                l = m + 1;
            }
        }

        return -1;
    }

    public int Index(int i, int k, int n) {
        return (i + k) % n;
    }
}