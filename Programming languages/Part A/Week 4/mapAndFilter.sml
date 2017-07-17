fun map(f, xs) = 
    case xs of
       [] => []
     | head::tail => (f head)::map(f, tail)

val x1 = map(fn x => x + 1, [4, 8, 12, 16])
val x2 = map(hd, [[1,2], [3,4], [5,6,7]])

fun filter (f, xs) =
    case xs of
       [] => []
     | head::tail => if f head
                     then head::filter(f, tail)
                     else filter(f, tail)

fun is_even v =
    (v mod 2) = 0

fun all_even xs = filter(is_even, xs)

fun all_even_snd xs = filter(fn (_, v) => is_even v, xs)