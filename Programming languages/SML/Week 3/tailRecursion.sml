fun fact n =
    if n = 0 then 1 else n * fact(n - 1)

val x = fact 3

fun fact_faster n =
    let
      fun aux (n, acc) =
        if n = 0
        then acc
        else aux(n-1, acc*n)
    in
      aux(n, 1)
    end

val x = fact_faster 3

fun sum xs =
    case xs of
       x::xs' => x + sum xs'
     | [] => 0

fun sumTail xs =
    let
      fun aux (xs, acc) =
        case xs of
           [] => acc
         | x::xs' => aux(xs', x+acc)
    in
      aux(xs, 0)
    end

fun rev xs = 
    case xs of
       [] => []
     | x::xs' => (rev xs') @ x

fun revTail xs =
    let
      fun aux(xs, acc) =
      case xs of
         [] => acc
       | x::xs' => aux(xs', x::acc)
    in
      aux(xs, [])
    end