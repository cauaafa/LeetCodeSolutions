public class Solution {
    public int MySqrt(int x) {
        if (x < 2) return x;

        int l = 1;
        int r = x / 2;
        int y = 0;

        while (l <= r) {
            int m = l + (r - l) / 2;

            long calc = (long)m * m;
            if (x == calc) return m;
            else if (calc < x) {
                y = m;
                l = m+1;
            } else {
                r = m - 1;
            }
        }
        return y;
    }
}