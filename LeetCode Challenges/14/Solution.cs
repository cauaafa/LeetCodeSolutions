public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";

        string s = strs.OrderBy(x => x.Length).First();
        string p = "";

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            foreach (string str in strs) {
                if (str[i] != c) return p;
            }
            p += c;
        }
        
        return p;
    }
}