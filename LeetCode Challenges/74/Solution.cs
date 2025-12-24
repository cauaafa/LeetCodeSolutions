public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {        
        int col = matrix.Length;
        int row = matrix[0].Length;

        int l = 0;
        int r = col * row - 1;

        while (l <= r) {
            int m = l + (r - l) / 2;

            int curC = m / row;
            int curR = m % row;

            int mVal = matrix[curC][curR];

            if(mVal == target) {
                return true;
            }
            if(mVal > target) {
                r = m - 1;
            } else {
                l = m + 1;
            }
        }

        return false;
    }
}