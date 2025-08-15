public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n == 1) return true;
        if (n < 0) return false;
        int p = 1;

        for (int i = 0; i < 31; i++) {
            p *= 2;
            if (p == n) {
                return true;
            }
        }
        return false;
    }
}