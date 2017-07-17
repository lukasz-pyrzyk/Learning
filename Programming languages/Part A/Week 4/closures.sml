fun filter (f, xs) =
    case xs of
       [] => []
     | head::tail => if f head
                     then head::filter(f, tail)
                     else filter(f, tail)

fun allShorterThan(xs, s) =
    filter(fn x => (print "!"; String.size x < String.size s), xs)

fun allShorterThanOptimized (xs, s) =
    let
      val i = String.size s
    in
      filter(fn x => (print "!"; String.size x < i), xs)
    end