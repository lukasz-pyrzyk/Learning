fun is_older (l : int*int*int, p : int*int*int) =
    if #1 l < #1 p
    then true
    else if #2 l < #2 p
    then true
    else if #3 l < #3 p
    then true
    else false

fun number_in_month (l : (int*int*int) list, month : int) =
    if null l
    then 0
    else if #2 (hd(l)) = month
    then 1 + number_in_month(tl(l), month)
    else number_in_month(tl(l), month)

    
fun number_in_months (l : (int*int*int) list, months : int list) =
    if null l
    then 0
    else if null months
    then 0
    else number_in_month(l, hd(months)) + number_in_months(l, tl(months))

fun dates_in_month (l : (int*int*int) list, month : int) =
    if null l
    then []
    else if #2 (hd(l)) = month
    then hd(l)::dates_in_month(tl(l), month)
    else dates_in_month(tl(l), month)

fun dates_in_months (l : (int*int*int) list, months : int list) =
    if null l
    then []
    else if null months
    then []
    else dates_in_month(l, hd(months)) @ dates_in_months(l, tl(months))

fun get_nth (l : string list, n : int) =
    if n = 1
    then hd(l)
    else get_nth(tl(l), n - 1)

fun date_to_string(date : (int*int*int)) =
    let
    val months = ["January", "February", "March", "April", "May", "June", "July", "September", "October", "November", "December"];
    val month = get_nth(months, #2 date);
    in
    month ^ " " ^ Int.toString(#3 date) ^ ", " ^ Int.toString(#1 date)
    end

fun number_before_reaching_sum(sum : int, l : int list) =
    if null l
    then 0
    else if hd(l) >= sum
    then 0
    else 1 + number_before_reaching_sum(sum - hd(l), tl(l))