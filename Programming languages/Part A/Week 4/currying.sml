fun sorted3_tupled (x, y, z) = z >= y andalso y >= x

val t1 = sorted3_tupled (7, 9, 11)

(* new way *)
val sorted3 = fn x => fn y => fn z => z >= y andalso y >= x

val t2 = ((sorted3 7) 9) 11
val t3 = sorted3 7 9 11

(* val wrong1 = sorted3_tupled 7 9 11 *)
(* val wrong2 = sorted3 (7, 9, 11) *)

fun sorted3_nicer x y z = z >= y andalso y >= x
val t4 = sorted3_nicer 7 9 11

fun fold f acc xs =
    case xs of
       [] => acc
     | head::tail => fold f(f(acc, head)) tail

fun sum xs = fold(fn (x, y) => x + y) 0 xs