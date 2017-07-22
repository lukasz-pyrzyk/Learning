val cbs : (int -> unit) list ref = ref []
fun onKeyEvent f = cbs := f :: (!cbs)

fun onEvent i =
    let
      fun loop fs =
        case fs of
           [] => ()
         | head::tail => (head i; loop tail)
    in
      loop (!cbs)
    end

val timesPressed = ref 0
val _ = onKeyEvent (fn _ => 
        timesPressed := (!timesPressed) + 1)

fun printIfPressed i =
    onKeyEvent (fn j =>
        if i = j
        then print("you pressed " ^ Int.toString i)
        else ()
)