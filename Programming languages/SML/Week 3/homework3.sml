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
fun get_substitutions1 (substitutions, s) =
  case substitutions of
     [] => []
   | head::tail => case all_except_option(s, head) of
                      NONE => get_substitutions1(tail, s)
                    | SOME x => x @ get_substitutions1(tail, s)
(* 1C *)
fun get_substitutions2 (substitutions, s) =
  let
    fun aux(substitutions, s, results) =
      case substitutions of
         [] => results
       | head::tail => case all_except_option(s, head) of
                      NONE => aux(tail, s, results)
                    | SOME x => aux(tail, s, results @ x)
  in
    aux(substitutions, s, [])
  end

(* 1D *)
fun similar_names (list, fullName) =
  let
    val {first=x, middle=y, last=z} = fullName
    fun similar_name(list) =
      case list of
          [] => []
        | head::tail => {first=head,middle=y,last=z}::similar_name(tail)
  in
    fullName::similar_name(get_substitutions2(list, x))
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
(* 2A *)
fun card_color (suit, rank) =
    case suit of
       Spades => Black
     | Clubs => Black
     | _    => Red

(* 2B *)
fun card_value (suit, rank) =
    case rank of
       Num i => i
     | Ace => 11
     | _ => 10

(* 2C *)
fun remove_card (cs, c, e) =
    case cs of
       [] => raise e
     | head::tail => if head = c
                     then tail
                     else head::remove_card(tail, c, e)
(* 2D *)
fun all_same_color cards =
    case cards of
        [] => true
      | _ ::[] => true
      | head::neck::tail => card_color(head) = card_color(neck) andalso all_same_color(neck::tail)

(* 2E *)
fun sum_cards cards =
    let
      fun aux(cards, acc) =
        case cards of
           [] => acc
         | head::tail => aux(tail, acc + card_value(head))
    in
      aux(cards, 0)
    end

(*2 F*)
fun score (cards, goal) =
  let
    val sum = sum_cards(cards)
    fun calculateResult (sum, goal) =
      if sum > goal
      then 3 * (sum - goal)
      else goal - sum
  in
    if all_same_color cards
    then calculateResult (sum, goal) div 2
    else calculateResult (sum, goal)
  end

(* 2G *)
fun officiate (cards, moves, goal) =
  let fun aux(cards, move_lst, heldcards) =
    case move_lst of
      [] => score(heldcards, goal)
    | Discard discard::tail => aux(cards, tail, remove_card(heldcards, discard, IllegalMove))
    | _::tail => case cards of
                      [] => score(heldcards, goal)
                    | first::rest => if sum_cards(first::heldcards) < goal
                                     then aux(rest, tail, first::heldcards)
                                     else score(first::heldcards, goal)
  in
    aux(cards, moves, [])
  end