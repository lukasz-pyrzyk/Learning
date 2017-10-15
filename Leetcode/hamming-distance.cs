public class Solution {
    public int HammingDistance(int x, int y) {
        int a = x ^ y;
        
        int result = 0;
        while(a > 0)
        {
            if((a & 1) == 1)
            {
                result++;
            }
            a >>= 1;
        }
        
        return result;
    }
}