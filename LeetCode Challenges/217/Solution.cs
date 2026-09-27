public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        int i = 0;
        HashSet<int> hsh = new HashSet<int>();
        for (i = 0; i < nums.Length; i++) {
            if (hsh.Contains(nums[i]))
                return true;
            hsh.Add(nums[i]);
        }

        return false;
    }
}