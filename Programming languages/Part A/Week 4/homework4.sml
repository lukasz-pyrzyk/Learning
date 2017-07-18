(* Coursera Programming Languages, Homework 3, Provided Code *)

exception NoAnswer

datatype pattern = Wildcard
		 | Variable of string
		 | UnitP
		 | ConstP of int
		 | TupleP of pattern list
		 | ConstructorP of string * pattern

datatype valu = Const of int
	      | Unit
	      | Tuple of valu list
	      | Constructor of string * valu

fun g f1 f2 p =
    let 
	val r = g f1 f2 
    in
	case p of
	    Wildcard          => f1 ()
	  | Variable x        => f2 x
	  | TupleP ps         => List.foldl (fn (p,i) => (r p) + i) 0 ps
	  | ConstructorP(_,p) => r p
	  | _                 => 0
    end

(**** for the challenge problem only ****)

datatype typ = Anything
	     | UnitT
	     | IntT
	     | TupleT of typ list
	     | Datatype of string

(* 1A *)
val only_capitals = List.filter (fn x => Char.isUpper(String.sub(x, 0)))

(* 1B *)
val longest_string1 = List.foldl (fn (x, y) => if String.size x > String.size y then x else y) ""

(* 1C *)
val longest_string2 = List.foldl (fn (x, y) => if String.size x >= String.size y then x else y) ""

fun longest_string_helper f = List.foldl (fn (x, y) => if f(String.size(x), String.size(y)) then x else y) ""
val longest_string3 = longest_string_helper (fn (x, y) => x > y)
val longest_string4 = longest_string_helper (fn (x, y) => x >= y)

