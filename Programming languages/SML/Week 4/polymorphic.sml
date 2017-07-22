fun times_until_zero(f, x) = (* (int => int) * int -> int *)
    if x = 0
    then 0
    else 1 + times_until_zero(f, f x)

fun len xs = (* 'a list -> int *)
    case xs of
       [] => 0
     | _::tail => 1 + len(tail)