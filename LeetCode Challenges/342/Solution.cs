public class Solution {
    public bool IsPowerOfFour(int n) {
        if (n == 1) return true; 
        if (n % 2 != 0) return false;

        return (Math.Log(n,4) % 1 == 0);
    }
}