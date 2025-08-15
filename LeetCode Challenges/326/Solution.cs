public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n == 1) return true;
        if (n <= 0) return false;

        int p = 1;
        for (int i = 0; i<19; i++) {
            p *= 3;
            if (p == n) {
                return true;
            }
        }
        return false;
    }
}