public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] prefnums = new int[nums.Length];
        int ind = 0;
        for (int i = 0; i < n; i++)
        {
            prefnums[i + ind] = nums[i];
            prefnums[i + ind + 1] = nums[i + n];
            ind++;
        }
        return prefnums;
    }
}