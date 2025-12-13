public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        List<IList<int>> res = new List<IList<int>>();
        List<int> cur = new List<int>();
        FindCombinations(0, target, candidates, cur, res);
        return res;
    }

    public void FindCombinations(int index, int target, int[] candidates, List<int> cur, List<IList<int>> res) {
        if (target == 0) {
            res.Add(new List<int>(cur));
            return;
        }

        for (int i = index; i < candidates.Length; i++) {
            if (candidates[i] <= target) {
                cur.Add(candidates[i]);

                FindCombinations(i, target - candidates[i], candidates, cur, res);

                cur.RemoveAt(cur.Count - 1);
            }
        }
    }
}