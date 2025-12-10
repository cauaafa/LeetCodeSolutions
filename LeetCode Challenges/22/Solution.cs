public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        StringBuilder s = new StringBuilder();

        Solve(res, s, 0, 0, n);

        return res;
    }

    public void Solve(List<string> res, StringBuilder s, int open, int close, int n) {
        if (close == n && open == n) {
            res.Add(s.ToString());
            return;
        }

        if (open < n) {
            s.Append('(');
            Solve(res, s, open + 1, close, n);
            s.Length--;
        }

        if (close < open) {
            s.Append(')');
            Solve(res, s, open, close + 1, n);
            s.Length--;
        }
    }
}