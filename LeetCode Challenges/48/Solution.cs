public class Solution {
    public void Rotate(int[][] matrix) {
        Transpose(matrix);
        Reverse(matrix);
    }

    public void Transpose(int[][] matrix) {
        for (int i = 0; i < matrix.Length; i++) {
            for (int j = i + 1; j < matrix.Length; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }

    public void Reverse(int[][] matrix) {
        for(int i = 0; i < matrix.Length; i++) {
            int x = 0;
            int y = matrix[i].Length - 1;

            while (x < y) {
                int temp = matrix[i][x];
                matrix[i][x] = matrix[i][y];
                matrix[i][y] = temp;
                x++;
                y--;
            }
        }
    }
}