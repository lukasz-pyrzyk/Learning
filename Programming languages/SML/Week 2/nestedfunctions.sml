
fun countup_from1 (x : int) =
    let
        fun count (from : int) = (* 3, 6 -> [3, 4, 5, 6] *)
            if from = x
            then x::[]
            else from::count(from+1)
    in
        count(1)
    end