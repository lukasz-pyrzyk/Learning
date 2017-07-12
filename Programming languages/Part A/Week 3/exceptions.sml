fun hd xs =
    case xs of
       [] => raise List.Empty
     | x::_ => x

exception MyUndesirableCondittion

exception MyOtherException of int * int
(* raise MyOtherException(3, 4)*)

fun myDiv(x, y) =
    if y = 0
    then raise MyUndesirableCondittion
    else x div y

fun maxList(xs, ex) =
    case xs of
       [] => raise ex
     | x::[] => x
     | x::xs' => Int.max(x, maxList(xs', ex))

val w = maxList ([3, 4, 5], MyUndesirableCondittion)

val x = maxList ([3, 4, 5], MyUndesirableCondittion)
    handle MyUndesirableCondittion => 42

(* e1 handle ex => e2 *)

val z = maxList ([], MyUndesirableCondittion)
    handle MyUndesirableCondittion => 42