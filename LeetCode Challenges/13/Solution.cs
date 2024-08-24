public class Solution
{
    public int RomanToInt(string s)
    {

        int result = 0;
        Dictionary<char, int> romanCNum = new Dictionary<char, int>();

        romanCNum.Add('I', 1);
        romanCNum.Add('V', 5);
        romanCNum.Add('X', 10);
        romanCNum.Add('L', 50);
        romanCNum.Add('C', 100);
        romanCNum.Add('D', 500);
        romanCNum.Add('M', 1000);

        int lastNum = 1000;

        for (int i = 0; i < s.Length; i++)
        {
            int curNum = romanCNum[s[i]];
            if (lastNum >= curNum)
            {
                result += curNum;
            }
            else
            {
                result += curNum - (lastNum * 2);
            }
            lastNum = curNum;
        }
        return result;
    }
}