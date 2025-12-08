public class Solution {
    public IList<string> LetterCombinations(string digits) {
        List<string> res = new List<string>();
        if (digits.Length == 0) return res;

        string[] chars = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

        Solve(0, digits, chars, ref res, "");
        
        return res;
    }

    public void Solve(int i, string digits, string[] chars, ref List<string> res, string t) {
        if (i == digits.Length) {
            res.Add(t);
            return;
        }

        foreach (char c in chars[digits[i] - 48]) {
            Solve(i + 1, digits, chars, ref res, t + c);
        }
    }
}