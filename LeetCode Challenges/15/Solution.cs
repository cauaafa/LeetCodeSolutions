public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> list = new List<IList<int>>();

        if (nums.Length < 3) return list;

        Array.Sort(nums);

        int a = 0;
        int b = 1;
        int c = nums.Length - 1;

        int target;

        while (a < nums.Length - 2) {
            target = nums[a] * -1;
            b = a + 1;
            c = nums.Length - 1;
            
            while (b < c) {
                if (nums[b] + nums[c] > target) {
                    c--;
                }
                else if (nums[b] + nums[c] < target) {
                    b++;
                }
                else {
                    List<int> solution = new List<int> { nums[a], nums[b], nums[c] };
                    list.Add(solution);

                    while(b < c && nums[b] == solution[1]) {
                        b++;
                    }
                    while(b < c && nums[c] == solution[2]) {
                        c--;
                    }
                }
            }
            int curStart = nums[a];
            while(a < nums.Length - 2 && nums[a] == curStart) {
                a++;
            }
        }

        return list;
    }
}