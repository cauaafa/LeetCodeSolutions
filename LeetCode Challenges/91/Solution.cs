public class Solution {
    public int NumDecodings(string s) {
        if (s[0] == '0') {
            return 0;
        }

        int[] dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;

        for (int i = 2; i <= s.Length; ++i) {
            int oneDigit = s[i - 1] - '0';
            int twoDigits = int.Parse(s.Substring(i - 2, 2));

            if (oneDigit != 0) {
                dp[i] += dp[i - 1];
            }

            if (10 <= twoDigits && twoDigits <= 26) {
                dp[i] += dp[i - 2];
            }
        }

        return dp[s.Length];
    }
}
