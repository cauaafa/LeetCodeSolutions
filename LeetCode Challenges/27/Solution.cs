public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int ind = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[ind] = nums[i];
                ind++;
            }
        }
        return ind;
    }
}