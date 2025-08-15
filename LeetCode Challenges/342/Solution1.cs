public class Solution {
    public bool IsPowerOfFour(int n) {
        if (n == 1) return true; 
        int p = 1;

        for(int i = 0; i<15; i++) {
            p *= 4;
            if (p == n) {
                return true;
            }
        }
        return false;
    }
}