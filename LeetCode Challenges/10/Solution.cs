public class Solution {
    public bool IsMatch(string s, string p) {
        return check(s, p, s.Length-1, p.Length-1);
    }

    public bool check(string s, string p, int i, int j) {
        if (i == -1 && j == -1) return true;

        else if(i >= 0 && j >= 0) {
            if (p[j] != '*') return (p[j] == '.' || p[j] == s[i]) && check(s, p, i-1, j-1);
            else {
                if (p[j-1] != '.' && p[j-1] != s[i]) return check(s, p, i, j-2);
                else return check(s, p, i-1, j-2) || check(s, p, i-1, j) || check(s, p, i, j-2);
            }
        }

        else if (i == -1) {
            if (p[j] == '*') return check(s, p, i, j-2);
        }

        return false;
    }
}