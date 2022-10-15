let rec pascalTriangle row col =
    match (row, col) with
    | (0, 0) -> 1
    | (row, col) when row < 0 || col < 0 -> 0
    | _ -> pascalTriangle (row-1) col + pascalTriangle (row-1) (col-1) 

pascalTriangle 0 0
pascalTriangle 1 0
pascalTriangle 2 0
pascalTriangle 2 1
pascalTriangle 2 2
pascalTriangle 3 0
pascalTriangle 3 1
pascalTriangle 3 2
pascalTriangle 3 3

let uncurry f (a, b) = f a b
let curry f a b = f (a, b)

let rec row n =
    match n with
    | 0 -> [1]
    | _ -> 
        let prev = [0] @ row (n-1) @ [0]
        List.map 
            (uncurry (+))
            (List.zip (List.take (prev.Length-1) prev) (List.tail prev))


let rec row n =
    match n with
    | 0 -> [1]
    | _ -> 
        let prev = [0] @ row (n-1) @ [0]
        List.map2
            (+)
            (List.take (prev.Length-1) prev) 
            (List.tail prev)

row 0
row 1
row 2
row 3

List.init 4 (fun v -> v + 5)

let f = fun v -> v + 5
let f1 = (+5)
let f2 x = 5+x

let a = +2
a





