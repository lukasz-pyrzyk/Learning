fun silly (z : int) = 
    let e
        val x = if z > 0 then z else 34
        val y = z + z + 9
    in
        if x > y then x * 2 else y * y
    end

fun silly2 () = 
    let
        val x = 1
    in
        let(let val x = 2 in x + 1 end) (* x is hidden *)+ (let val y = x + 2 in y + 1) (* x is not hidden *)
    end