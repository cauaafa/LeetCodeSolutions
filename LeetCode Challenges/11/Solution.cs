public class Solution {
    public int MaxArea(int[] height) {
        if (height.Length == 0) return 0;

        int i = 0;
        int j = height.Length - 1;

        int mostWater = 0;

        while (i < j) {
            int val = Math.Min(height[i], height[j]) * (j - i);
            mostWater = Math.Max(mostWater, val);

            if (height[i] < height[j]) {
                i++;
            } else {
                j--;
            }
        }

        return mostWater;
    }
}