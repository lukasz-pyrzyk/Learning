public class Solution {
    public string ReverseString(string s) {
        var chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}