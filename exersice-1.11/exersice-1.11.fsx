let rec f n =
    if n < 3
    then n
    else f (n-1) + 2*f (n-2) + 3*f (n-3)

f 0
f 1
f 2
f 3
f 4
f 5
f 6
f 7

let f n =

    let rec fIter num1 num2 num3 count =
        if count = 0
        then num3
        else fIter num2 num3 (3*num1 + 2*num2 + num3) (count-1)
    
    if n < 3
    then n
    else fIter 0 1 2 n

let f n =
    let rec fIter num1 num2 num3 count =
        match (n, count) with
        | (n, _) when n < 3 -> n
        | (_, count) when count <= 0 -> num3
        | _ -> fIter num2 num3 (3*num1 + 2*num2 + num3) (count-1)

    fIter 0 1 2 n

f 0
f 1
f 2
f 3
f 4
f 5
f 6
f 7