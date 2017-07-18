val x = ref 42
val y = ref 42
val z = x
val _ = x := 43 (* change value of the reference *)
val w = (!y) + (!z) (* 85 *)
