func reverseString(s string) string {
    runes := make([]rune, utf8.RuneCountInString(s));
    i := len(s);
    
    for _, c := range s {
        i--;
        runes[i] = c;
    }
    
    return string(runes);
}