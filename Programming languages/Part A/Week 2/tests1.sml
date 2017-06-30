val test1_1 = is_older ((1,2,3),(2,3,4)) = true
val test1_2 = is_older ((1,2,3),(1, 2, 3)) = false
val test1_3 = is_older ((2,3,4),(1, 2, 3)) = false

val test2_1 = number_in_month ([(2012,3,28),(2013,12,1)],2) = 0
val test2_2 = number_in_month ([(2012,2,28),(2013,12,1)],2) = 1
val test2_3 = number_in_month ([(2012,2,28),(2013,2,1)],2) = 2

val test3 = number_in_months ([(2012,2,28),(2013,12,1),(2011,3,31),(2011,4,28)],[2,3,4]) = 3

val test4_1 = dates_in_month ([(2012,2,28),(2013,12,1)],5) = []
val test4_2 = dates_in_month ([(2012,2,28),(2013,12,1)],2) = [(2012,2,28)]
val test4_3 = dates_in_month ([(2012,2,28),(2013,2,1)],2) = [(2012,2,28), (2013,2,1)]

val test5 = dates_in_months ([(2012,2,28),(2013,12,1),(2011,3,31),(2011,4,28)],[2,3,4]) = [(2012,2,28),(2011,3,31),(2011,4,28)]
