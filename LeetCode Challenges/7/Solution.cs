public class Solution {
    public int Reverse(int x) {
        if (x == 0) return 0;
        if (x == int.MinValue) return 0;

        int m = x < 0 ? -1 : 1;
        int w = 0;
        int r = Math.Abs(x);

        while (r != 0) {
            int pop = r % 10;
            r /= 10;

            if (w > 214748364 || (w == 214748364 && pop > 7)) return 0;
            w = w * 10 + pop;
        }

        w *= m;
        if (w < -2147483648 || w > 2147483647) return 0;
        return w;
    }
}