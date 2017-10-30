public class Solution {
    public bool JudgeCircle(string moves) {
        int horizontal = 0, vertical = 0;
        foreach(char c in moves)
        {
            switch (c) 
            {
                case 'U': 
                    vertical++; 
                break;
                case 'D': 
                    vertical--; 
                break;
                case 'R': 
                    horizontal++; 
                break;
                case 'L': 
                    horizontal--; 
                break;
            }
        }
        
        return horizontal == 0 && vertical == 0;
    }
}