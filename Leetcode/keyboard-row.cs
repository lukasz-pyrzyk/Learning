public class Solution {
    public string[] FindWords(string[] words) {
        var firstLine = new HashSet<char>(new[] {'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'});
        var second = new HashSet<char>(new[] {'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'});
        var third = new HashSet<char>(new[] {'z', 'x', 'c', 'd', 'v',' b', 'n', 'm'});
        
        var results = new List<string>();
        foreach(var word in words)
        {
            if(word.All(x => firstLine.Contains(x) || second.All(x => firstLine.Contains(x) || word.All(x => third.Contains(x))
            {
                results.Add(word);
            }
        }
        return results.ToArray();
    }
}