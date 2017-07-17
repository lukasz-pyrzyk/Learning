fun n_times(f, n, x) =
    if n = 0
    then x
    else f (n_times(f, n-1, x))

fun triple_n_times (n, x) = 
    let
        fun triple x = 3 * x
    in
      n_times(triple, n, x)
    end

fun triple_n_times2 (n, x) =
    n_times(let fun triple x = 3 * x in triple end, n, x)

fun triple_n_times3 (n, x) = n_times((fn x => 3 * x), n, x)

fun triple_n_times4 (n, x) = n_times(fn x => 3 * x, n, x)

(* poor style *)
val triple_n_times5 = fn (n, x) => n_times(fn y => 3*y, n, x)