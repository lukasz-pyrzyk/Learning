public class Solution {
    public string[] FindWords(string[] words) {
        var rows = new HashSet<char>[] {
            new HashSet<char>(new[] {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'}),
            new HashSet<char>(new[] {'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'}),
            new HashSet<char>(new[] {'z', 'x', 'c', 'b', 'v', 'b', 'n', 'm'})
        };
        
        var results = new List<string>();
        foreach(var word in words)
        {
            char[] chars = word.ToCharArray();
            if(rows.Any(r => chars.All(c => r.Contains(Char.ToLower(c)))))
            {
                results.Add(word);
            }
        }
        return results.ToArray();
    }
}