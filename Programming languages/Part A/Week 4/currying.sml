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

fun is_nonnegative x = sorted3 0 0 x
val is_nonnegative1 = sorted3 0 0

fun sum xs = fold(fn (x, y) => x + y) 0 xs
val sum = fold(fn (x, y) => x + y) 0

fun range i j = if i > j then [] else i :: range(i + 1) j
val countup = range 1 (* countup 6 => [1, 2, 3, 4, 5, 6]*)

fun exists predicate xs =
  case xs of
     [] => false
   | head::tail => predicate head orelse exists predicate tail

val no = exists (fn x => x = 7) [4, 11, 23]
val hasZero = exists (fn x=> x = 7)
val incramentAll = List.map (fn x => x + 1)
val removeZeros = List.filter(fn x => x <> 0)

val pairWithOne = List.map (fn x => (x, 1)) (* warning... *)
fun pairWithOneCorrect xs = List.map (fn x => (x, 1)) xs
val pairWithOneCorrectWithoutPolimorphic : string list -> (string * int) list = List.map (fn x => (x, 1))

(* summary *)
fun other_curry f = fn x => fn y => f y x
fun other_curry2 f x y = f y x
fun curry f x y = f (x, y)
fun uncurry f (x, y) = f x y