public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<IList<int>> res = new List<IList<int>>();
        Backtrack(0, target, new List<int>(), candidates, ref res);
        return res;
    }

    void Backtrack(int start, int remaining, List<int> currentCombination, int[] candidates, ref List<IList<int>> res)
    {
        if (remaining == 0)
        {
            res.Add(new List<int>(currentCombination));
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1]) continue;
            if (candidates[i] > remaining) break;

            currentCombination.Add(candidates[i]);
            Backtrack(i + 1, remaining - candidates[i], currentCombination, candidates, ref res);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }
}