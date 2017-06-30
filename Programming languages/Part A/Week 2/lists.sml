val empty = [];
val array = [3, 4, 5];
val evaluated_array = [(1+2), (2+2), 5)];
val array_of_booleans = [true, false, true];
(* all values must be the same type! *)

val t = [6]::[[7,5],[5,2]] (*list of lists, [0] = 6, [1] = 7,5, [2] = 5,2*)

(* Checking if list is empty *)
null t (*where t is a binding to list. Null of [] -> true, in another case false*) 

(* Taking a head of list *)
hd t

(* Taking a tail of list *)
tl t


val e = []; (* alpha list, generic list *)