public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        var res = new List<IList<string>>();
        void Solve(int row, int[] queens, bool[] cols, bool[] diag1, bool[] diag2) {
            if (row == n) {
                var board = new List<string>();
                for (int i = 0; i < n; i++) {
                    char[] rowArr = new char[n];
                    Array.Fill(rowArr, '.');
                    rowArr[queens[i]] = 'Q';
                    board.Add(new string(rowArr));
                }
                res.Add(board);
                return;
            }
            for (int col = 0; col < n; col++) {
                if (cols[col] || diag1[row + col] || diag2[row - col + n - 1]) continue;
                queens[row] = col;
                cols[col] = diag1[row + col] = diag2[row - col + n - 1] = true;
                Solve(row + 1, queens, cols, diag1, diag2);
                cols[col] = diag1[row + col] = diag2[row - col + n - 1] = false;
            }
        }
        Solve(0, new int[n], new bool[n], new bool[2*n-1], new bool[2*n-1]);
        return res;
    }

}