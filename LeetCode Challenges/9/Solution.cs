public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {return false;} else if (x < 10) {return true;}
        long y = 1;
        int w = x;
        while(y*10 < x) {y *=10;}
        while(x > 0) {
            try{
                
             if(!(x % 10 == ((w / y)) % 10)) {
                return false;
            }
            y /= 10;
            x /= 10;  
                } catch {
                return false;
                }        
        }
        return true;
    }
}