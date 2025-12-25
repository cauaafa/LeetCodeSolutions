public class Solution {
    public bool Exist(char[][] board, string word) {
        int first = 0;
        int last = 0;
        
        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                if (board[i][j] == word[0]) first++;
                else if (board[i][j] == word[word.Length-1]) last++;
            }
        }

        if (first > last) {
            char[] array = word.ToCharArray(); 
            Array.Reverse(array); 
            word = new string(array); 
        }

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {
                if (DFS(i,j, board, word, 0)) return true;
            }
        }
        return false;
    }

    public bool DFS(int i, int j, char[][] board, string word, int idx) {
        if (idx == word.Length) return true;
        else if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length) return false;
        else if (board[i][j] != word[idx]) return false;

        char c = board[i][j];
        board[i][j] = '.';
        bool res =  DFS(i+1,j, board, word, idx + 1) 
            || DFS(i-1,j, board, word, idx + 1)
            || DFS(i,j+1, board, word, idx + 1)
            || DFS(i,j-1, board, word, idx + 1);
        board[i][j] = c;

        return res;
    }

}