public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> list = new List<IList<int>>();
        List<int> cur = new List<int>();

        void Backtrack(int i) {
            list.Add(new List<int>(cur));
            for (int j = i; j < nums.Length; j++) {
                cur.Add(nums[j]);
                Backtrack(j + 1);
                cur.RemoveAt(cur.Count - 1);
            }
        }

        Backtrack(0);
        return list;
    }
}