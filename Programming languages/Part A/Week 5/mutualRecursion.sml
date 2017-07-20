(* Mutual recursive functions *)
(* fun f1 p1 = e1
and f2 p2 = e2
and f3 p3 = e3 *)

(* Similarly, mutually recursive datatype bindings 
datatype t1 = ...
and t2 = ...
and t3 = ...
*)

fun match xs =
    let 
    fun s_need_one xs =
        case xs of
           [] => true
         | 1::tail => s_need_two tail
         | _ => false
    and s_need_two xs =
        case xs of
           [] => false
         | 2::tail => s_need_one tail
         | _ => false
    in
        s_need_one xs
    end