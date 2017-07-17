fun append([], ys) = ys
    | append (x::xs', ys) = x :: append(xs', ys)

(*
    fun f x = 
        case x of
            p1 => e1
          | p2 => e2
        ...

can be written as
    fun f p1 = e1
        | f p2 = e2
        ...
        | f pn = en
*)