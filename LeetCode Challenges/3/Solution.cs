public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length <= 0) return 0;

        HashSet<char> window = new HashSet<char>();
        int left = 0;
        int right = 0;
        int biggest = 0;
        
        while (right < s.Length) {
            if (!window.Contains(s[right])) {
                window.Add(s[right]);
                right++;
                biggest = Math.Max(biggest, window.Count);
            } else {
                window.Remove(s[left]);
                left++;
            }
        }

        return biggest;
    }
}