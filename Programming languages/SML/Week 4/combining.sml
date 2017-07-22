fun compose (f, g) = fn x => f(g, x)

fun sqrt_of_abs i = Math.sqrt(Real.fromInt(abs i))
fun sqrt_of_abs1 i = (Math.sqrt o Real.fromInt o abs) i
val aqrt_of_abs2 = Math.sqrt o Real.fromInt o abs

(* |> in F# *)
(* !> will be used *)

infix !> 
fun x !> f = f x

fun sqrt_of_abs3 i = i !> abs !> Real.fromInt !> Math.sqrt

fun backup1 (f, g) = fn x => case f x of 
                                NONE => g x 
                              | SOME y => y

fun backup2 (f, g) = fn x => f x handle _ => g x

fun mystery f = fn xs =>  
    let
        fun g xs =
           case xs of
               [] => NONE
             | x::xs' => if f x then SOME x else g xs'
    in
        case xs of
            [] => NONE
          | x::xs' => if f x then g xs' else mystery f xs'
    end

fun null xs = xs =[]