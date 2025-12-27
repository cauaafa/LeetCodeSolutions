public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> list = new List<IList<int>>();
        List<int> cur = new List<int>();
        Backtrack(nums, 0, cur, list);

        return list;
    }

    public void Backtrack(int[] nums, int i, List<int> cur, List<IList<int>> list) {
        list.Add(new List<int>(cur));
         
        for (int j = i; j < nums.Length; j++) {
            if (j > i && nums[j] == nums[j-1]) continue;

            cur.Add(nums[j]);
            Backtrack(nums, j + 1, cur, list);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}
