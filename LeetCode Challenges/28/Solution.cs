public class Solution {
    public int StrStr(string haystack, string needle) {
        int startIndex = -1;
        int curIndex = 0;
        bool isGoing = false;

        int i = 0;

        while(i < haystack.Length) {
            Console.WriteLine(haystack[i] + " : " +needle[curIndex]);
            if (haystack[i] == needle[curIndex]) {
                if (isGoing == false) {
                    startIndex = i;
                }
                isGoing = true;
                curIndex++;
                if (curIndex == needle.Length) {
                    return startIndex;
                }
            } else {
                curIndex = 0;
                if (isGoing == true) {
                    i = startIndex;
                }
                isGoing = false;
                startIndex = -1;
            }
            i++;
        }
        if (curIndex < needle.Length) {
            return -1;
        }
        return startIndex;
    }
}