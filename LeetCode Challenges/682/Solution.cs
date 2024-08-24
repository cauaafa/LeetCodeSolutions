public class Solution
{
    public int CalPoints(string[] operations)
    {
        List<int> nums = new List<int>();
        for (int i = 0; i < operations.Length; i++)
        {
            int last = nums.Count - 1;
            switch (operations[i])
            {
                case "C":
                    nums.RemoveAt(last);
                    break;
                case "D":
                    nums.Add(nums[last] * 2);
                    break;
                case "+":
                    nums.Add(nums[last] + nums[last - 1]);
                    break;
                default:
                    nums.Add(Int32.Parse(operations[i]));
                    break;
            }

        }
        return nums.Sum();
    }
}