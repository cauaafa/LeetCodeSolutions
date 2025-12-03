public class Solution {
    public int LengthOfLastWord(string s) {
        int len = 0;
        int curIndex = s.Length-1;
        bool started = false;

        while (curIndex >= 0) {
            if (s[curIndex] == ' ') {
                if (started) {
                    return len;
                } else {
                    curIndex--;
                }
            } else {
                started = true;
                len++;
                curIndex--;
            }
        }
        return len;
    }
}