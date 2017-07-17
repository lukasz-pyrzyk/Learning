val x = 1 (* maps to 1 *)
fun f y = x + y (* f maps to a function that adds 1 to its argument *)
val x = 2 (* x maps to 2 *)
val y = 3 (* y maps to 2 *)
val z = f (x + y) (call the function defined on the line 2 with 5)

val x = 1
fun f y =
    let
      val x = y + 1
    in
      fn z => x + y + z
    end

val x = 3
val g = f 4
val y = 5
val z = g 6


fun f g =
    let
      val x = 3
    in
      g 2
    end

val x = 4
fun h y = x + y
val z = f h

(* Lexical scope: use environment where function is defined *)
val x = 1 (* maps to 1 *)
fun f y = x + y (* f maps to a function that adds 1 to its argument *)
val x = 2 (* x maps to 2 *)
val y = 3 (* y maps to 2 *)
val z = f (x + y) (call the function defined on the line 2 with 5)

val x = 1
fun f y =
    let
      val x = y + 1
    in
      fn z => x + y + z
    end

val x = 3
val g = f 4
val y = 5
val z = g 6


fun f g =
    let
      val x = 3
    in
      g 2
    end

val x = 4
fun h y = x + y
val z = f h

(* Lexical scope: use environment where function is defined *)
val x = 1 (* maps to 1 *)
fun f y = x + y (* f maps to a function that adds 1 to its argument *)
val x = 2 (* x maps to 2 *)
val y = 3 (* y maps to 2 *)
val z = f (x + y) (call the function defined on the line 2 with 5)

val x = 1
fun f y =
    let
      val x = y + 1
    in
      fn z => x + y + z
    end

val x = 3
val g = f 4
val y = 5
val z = g 6


fun f g =
    let
      val x = 3
    in
      g 2
    end

val x = 4
fun h y = x + y
val z = f h

(* Lexical scope: use environment where function is defined *)
(* Dynamic scope: use environment where function is called *)

