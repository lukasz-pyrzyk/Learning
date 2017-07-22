fun sum_triple triple =
    case triple of
        (x, y, z) => z + y + z

fun full_name r =
    case r of
        {first=x, middle=y, last=z} => x ^ " " ^ y " " ^ z

(* pattern matching by case {V} of for single case is a poor style. It shoud be done in following way: *)
fun sum_triple_better triple =
    let val (x, y, z) = triple
    in
        x + y + z
    end

fun full_name_better r =
    let val {first = x, middle = y, last = z} = r
    in 
        x ^ " " ^ y " " ^ z
    end

(* which can be written by *)
fun sum_triple_best (x, y, z) =
    x + y + z

fun full_name_best {first=x, middle=y, last=z} =
    x ^ " " ^ y " " ^ z

fun rotate_left (x, y, z) = (y, z, x)
fun rotate_right t = rotate_left(rotate_left t)

(*
a::b::c::d matches all lists with >= 3 elements
a::b::c::[] maches all lists with 3 elements
(a, b), (cd))::e non empty lists of pairs of pairs
*)