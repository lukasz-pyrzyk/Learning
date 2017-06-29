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