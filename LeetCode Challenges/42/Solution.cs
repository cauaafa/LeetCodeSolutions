public class Solution {
    public int Trap(int[] height) {
        int total = 0;
        int l = 0;
        int r = height.Length - 1;
        int lmax = 0;
        int rmax = height[r];
        
        while (l < r) {
            if (height[l] <= height[r]) {
                if (height[l] < lmax) {
                    total += lmax - height[l];
                } else {
                    lmax = height[l];
                }
                l++;
            } else {
                if (height[r] < rmax) {
                    total += rmax - height[r];
                } else {
                    rmax = height[r];
                }
                r--;
            }
        }
        return total;
    }
}