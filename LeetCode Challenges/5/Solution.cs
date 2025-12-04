public class Solution {
    public string LongestPalindrome(string s) {
        int l = 0;
        int r = 0;

        for (int i = 0; i < s.Length; i++) {
            int oddLen = Expand(s, i, i);
            if (oddLen > r - l + 1) {
                int dist = oddLen / 2;
                l = i - dist;
                r = i + dist;
            }

            int evenLen = Expand(s, i, i + 1);
            if (evenLen > r - l + 1) {
                int dist = (evenLen / 2) - 1;
                l = i - dist;
                r = i + dist + 1;
            }
        }

        return s.Substring(l, r - l + 1);
    }

    private int Expand(string s, int i, int j) {
        int left = i;
        int right = j;

        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }

        return right - left - 1;
    }
}