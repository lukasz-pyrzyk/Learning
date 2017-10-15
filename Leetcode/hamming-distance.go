func hammingDistance(x int, y int) int {
    n := x ^ y;
    result := 0;
    for n > 0 {
        if((n & 1) == 1){
            result++;
        }
        n >>= 1;
    }
    
    return result;
}