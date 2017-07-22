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

(* 1 *)
val only_capitals = List.filter (fn x => Char.isUpper(String.sub(x, 0)))

(* 2 *)
val longest_string1 = List.foldl (fn (x, y) => if String.size x > String.size y then x else y) ""

(* 3 *)
val longest_string2 = List.foldl (fn (x, y) => if String.size x >= String.size y then x else y) ""

(* 4 *)
fun longest_string_helper f = List.foldl (fn (x, y) => if f(String.size(x), String.size(y)) then x else y) ""
val longest_string3 = longest_string_helper (fn (x, y) => x > y)
val longest_string4 = longest_string_helper (fn (x, y) => x >= y)

(* 5 *)
val longest_capitalized = longest_string1 o only_capitals

(* 6 *)
val rev_string = String.implode o List.rev o String.explode

(* 7 *)
fun first_answer f arg =
	case arg of
	   [] => raise NoAnswer
	 | head::tail => case f head of
						  NONE => first_answer f tail
						| SOME x => x

(* 8 *)
fun all_answers f arg =
	let
	  fun aux(v, acc) =
	  	case v of
			 [] => SOME acc
		   | head::tail => case f head of
						NONE => NONE
					  | SOME x => aux(tail, acc @ x)
	in
	  aux(arg, [])
	end

(* 9a *)
val count_wildcards = g (fn () => 1) (fn x => 0)

(* 9b *)
val count_wild_and_variable_lengths = g (fn () => 1) (fn x => String.size x)

(* 9c *)
fun count_some_var (s, pattern) = g (fn () => 1) (fn x => if x = s then 1 else 0) pattern

(* 10 *)
fun check_pat pattern = 
	let
		fun isUnique list =
			case list of
			   [] => true
			 | head::tail => (isUnique tail) andalso (not (List.exists (fn s => s = head) tail))
	  	fun all p =
			case p of
				Variable x => [x]
			  | TupleP ps => List.foldl(fn (x, y) => y @ (all x)) [] ps
			  | ConstructorP (_, p) => all p
			  | _ => []

	in
	  isUnique(all(pattern))
	end

(* 11 *)
fun match (valu, pattern) =
    case (valu, pattern) of
         (v, Variable s) => SOME [(s, v)]
      | (Const i, ConstP j) => if i = j then SOME [] else NONE
      | (Tuple v, TupleP p) => if List.length v = List.length p then all_answers match (ListPair.zip(v, p)) else NONE
      | (Constructor(s2, v), ConstructorP(s1, p)) => if s1 = s2 then match(v, p) else NONE
	  | (_, Wildcard) => SOME []
	  | (Unit, UnitP) => SOME []
      | (_, _) => NONE

(* 12 *)
fun first_match value patterns = SOME (first_answer (fn x => match(value, x)) patterns) 
									handle NoAnswer => NONE