func judgeCircle(moves string) bool {
    vertical := 0; horizontal := 0;
    for _, char := range moves {
        switch char {
            case 'U': 
                vertical++;
            case 'D': 
                vertical--; 
            case 'R': 
                horizontal++; 
            case 'L': 
                horizontal--; 
        }
    }
    
    return vertical == 0 && horizontal == 0;
}