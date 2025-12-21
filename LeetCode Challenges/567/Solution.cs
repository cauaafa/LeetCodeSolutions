public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        var currWindow = new int[26];
        foreach(var ch in s1) {
            currWindow[ch - 'a']++;
        }

        int l = 0;
        int r = 0;

        while (r < s2.Length) {
            currWindow[s2[r] - 'a']--;

            while (currWindow[s2[r] - 'a'] < 0) {
                currWindow[s2[l] - 'a']++;
                l++;
            }

            r++;
            if (r - l == s1.Length) {
                return true;
            }
        }
        return false;
    }
}