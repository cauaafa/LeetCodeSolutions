public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int len = nums.Length;
        Array.Resize<int>(ref nums, len * 2);
        for (int i = 0; i < len; i++)
        {
            nums[len + i] = nums[i];
        }
        return nums;
    }
}