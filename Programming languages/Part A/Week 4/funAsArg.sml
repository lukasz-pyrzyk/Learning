fun incrament_n_times_lame (n, x) =
    if n = 0
    then x
    else 1 + incrament_n_times_lame(n - 1, x)

fun double_n_times_lame (n, x) =
    if n = 0
    then x
    else 2 * double_n_times_lame(n - 1, x)

fun nth_tail_lame (n, xs) =
    if n = 0
    then xs
    else tl (nth_tail_lame(n -1, xs))

fun n_times(f, n, x) =
    if n = 0
    then x
    else f (n_times(f, n-1, x))

fun incrament x = x + 1
fun double x = x + x

val x1 = n_times(double, 4, 7)
val x2 = n_times(incrament, 4, 7)
val x3 = n_times(tl, 2, [4, 8, 12, 16])

fun addition(n, x) = n_times(incrament, n, x)
fun double_n_times(n, x) = n_times(double, n, x)
fun nth_tail (n, xs) = n_times(tl, n, xs)

fun triple x = 3 * x
fun triple_n_times (n, x) = n_times(triple, n, x)