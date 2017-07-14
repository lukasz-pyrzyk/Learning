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
(* fun get_substitutions1 (substitutions, str) = *)

(* you may assume that Num is always used with values 2, 3, ..., 10
   though it will not really come up *)
datatype suit = Clubs | Diamonds | Hearts | Spades
datatype rank = Jack | Queen | King | Ace | Num of int 
type card = suit * rank

datatype color = Red | Black
datatype move = Discard of card | Draw 

exception IllegalMove

(* put your solutions for problem 2 here *)

fun card_color (suit, rank) =
    case suit of
       Spades => Black
     | Clubs => Black
     | _    => Red

fun card_value (suit, rank) =
    case rank of
       Num i => i
     | Ace => 11
     | _ => 10

fun remove_card (cs, c, e) =
    case cs of
       [] => raise e
     | head::tail => if head = c
                     then tail
                     else head::remove_card(tail, c, e)

fun all_same_color (cards) =
    case cards of
        [] => true
      | _ ::[] => true
      | head::(neck::tail) => card_color(head) = card_color(neck) andalso all_same_color(neck::tail)