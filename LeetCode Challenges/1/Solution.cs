public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Console.WriteLine(nums);
        int[] arrayN = [];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int x = 0; x < nums.Length; x++)
            {
                if (i != x)
                {
                    if ((nums[i] + nums[x]) == target)
                    {
                        arrayN = [i, x];
                    }
                }
            }
        }
        return arrayN;
    }
}