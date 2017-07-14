(* Dan Grossman, Coursera PL, HW2 Provided Code *)

(* if you use this function to compare two strings (returns true if the same
   string), then you avoid several of the functions in problem 1 having
   polymorphic types that may be confusing *)
fun same_string(s1 : string, s2 : string) =
    s1 = s2

(* 1A *)
fun all_except_option (s, list) =
    case list of
       [] => NONE
     | head::tail => if same_string(s, head)
               then SOME tail
               else
                   case all_except_option(s, tail) of
                      NONE => NONE
                    | SOME x => SOME (head::x)

(* 1B *)
fun get_substitutions1 (substitutions, str) =
    case substitutions of
       [] => []
     | head::tail => case all_except_option(str, head) of
                     NONE => get_substitutions1(tail, str)
                   | SOME xs => xs @ get_substitutions1(tail, str)

(* 1C *)
fun get_substitutions2 (substitutions, str) =
    let
      fun aux(subs, acc) =
        case subs of
            [] => []
          | head::tail => case all_except_option(str, head) of
                            NONE => aux(tail, acc)
                          | SOME xs => aux(tail, xs @ acc)
    in
      aux(substitutions, [])
    end

(* you may assume that Num is always used with values 2, 3, ..., 10
   though it will not really come up *)
datatype suit = Clubs | Diamonds | Hearts | Spades
datatype rank = Jack | Queen | King | Ace | Num of int 
type card = suit * rank

datatype color = Red | Black
datatype move = Discard of card | Draw 

exception IllegalMove

(* put your solutions for problem 2 here *)
