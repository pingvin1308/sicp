// (pow((1 + sqrt(5))/2, n) - pow((1 - sqrt(5))/2, n)) / sqrt(5)

let fib n=
    let rec fibIter a b count =
        if count = 0
        then b
        else fibIter (a+b) a (count-1)

    fibIter 1 0 n

fib 10

let fib2 n = 
    let pfi = (1. + sqrt(5.)) / 2.
    let psi = (1. - sqrt(5.)) / 2.

    (pfi**n - psi**n) / sqrt(5.)
    |> int

fib2 10

let fib3 n = 
    let pfi = (1. + sqrt(5.)) / 2.

    pfi**n / sqrt(5.)
    |> int

fib3 10

let p = 1

fib p = fib2 p
fib p = fib3 p

let k = 42

fib k = fib2 k
fib k = fib3 k

fib (k+1) = fib2 (float (k+1))
fib (k+1) = fib3 (float (k+1))
