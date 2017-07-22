signature MATHLIB =
sig
  val fact : int -> int
  val halp_pi : real
  val doubler : int -> int
end

structure MyMathLib :> MATHLIB =
struct
  fun fact x =  if x = 0
    then 1
    else x * fact(x - 1)
  val halp_pi = Math.pi / 2.0
  fun doubler x = x * 2
end

