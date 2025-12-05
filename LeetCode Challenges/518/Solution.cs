public class Solution {
    public int Change(int amount, int[] coins) {
        if (coins.Length == 0) return 0;
        
        int[] ways = new int[amount+1];
        ways[0] = 1;

        foreach(int i in coins) {
            for(int j = 0; j <= amount; j++) {
                if (j >= i) {
                    ways[j] += ways[j-i];
                }
            }
        }

        return ways[amount];
    }
}