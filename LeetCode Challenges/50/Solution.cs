public class Solution {
    public double MyPow(double x, int n) {
        double result = 1;
        long power = Math.Abs((long)n);

        while (power > 0) {
            if ((power & 1) == 1) result *= x;

            x *= x;
            power >>= 1;
        }

        return n < 0 ? 1 / result : result;
    }
}