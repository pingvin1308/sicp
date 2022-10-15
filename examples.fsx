12 + 42
(+) 12 42

21 + 35 + 12 + 7
[ 21; 35; 12; 7] |> List.sum
List.sum [ 21; 35; 12; 7]  
List.sum([ 21; 35; 12; 7])

(3 * (2 * 4 + (3 + 5))) + ((10 - 7) + 6)


let size = 2

let pi = 3.14159
let radius = 10.

pi * radius**2

let circumference =  2. * pi * radius

((2+4*6) * (3+5+7))

let square x : float = x**2
square 21
square (2. + 5.)
square <| 2. + 5.
2. + 5. |> square
2 + 5 |> float |> square


let sumOfSquares x y = square x + square y
sumOfSquares 3 4

let f a = sumOfSquares (a + 1.) (a * 2.)
f 5

// ; (define (abs x)
// ;   (cond ((> x 0) x)
// ;         ((= x 0) 0)
// ;         ((< x 0) (- x))))

// let abs x = 
//     match x with
//     | 0 -> 0
//     | a when a > 0 -> a
//     | a when a < 0 -> -a

// abs 12
// abs 0
// abs -42

// let abs x = 
//     match x with
//     | a when a > 0 -> a
//     | a when a < 0 -> -a
//     | _ -> 0

// abs 12
// abs 0
// abs -42

// let abs x : float = if x < 0 then -x else x

// abs 12
// abs 0
// abs -42

// (define (testCond x)
//   (and (> x 5) (< x 10)))

let testCond x = (5 < x) && (x < 10)

testCond 42
testCond 7
testCond -10

// let (>=) x y = (x > y) || (x = y)

(>=) 6 10
6 >= 10

(>=) 10 10
10 >= 10

(>=) 11 10
11 >= 10

(5. + 4. + 2. - 3. - 6. + 4./5.) / (3. * (6.-2.) * (2.-7.))


// ; (define (golloolo x y z)
// ;   (cond ((and (>= x z) (>= y z)) (sum-of-squares x y))
// ;         ((and (>= x y) (>= z y)) (sum-of-squares x z))
// ;         (else (sum-of-squares y z))))

let golloolo x y z = 
    match (x, y, z) with
    | (x, y, z) when x >= z && y >= z -> sumOfSquares x y
    | (x, y, z) when x >= y && z >= y -> sumOfSquares x z
    | _ -> sumOfSquares y z

let golloolo y x z = sumOfSquares (max x y) (max y z)

golloolo 1 1 1
golloolo 2 1 2
golloolo 1 2 2
golloolo 1 2 1
golloolo 2 2 1

golloolo 3 2 1
golloolo 1 2 2
golloolo 3 1 3
golloolo 5 1 3
golloolo 3 3 3
golloolo 1 5 3
golloolo 3 5 1

let square x : float = x**2
let average x y = (x + y) / 2.
let improve guess x = average guess (x / guess)

let goodEnough guess x =
    let nextGuess = improve guess x
    let guessDiff = (nextGuess - guess) / guess

    guessDiff
    |> abs 
    |> (>) 0.00000001

let rec sqrtIter  guess x =
    if goodEnough guess x
    then guess
    else sqrtIter (improve guess x) x

let sqrt x = 
    sqrtIter 1.0 x

sqrt 4
sqrt 9
sqrt 2

let cubeRoot x =
    let improve guess  = (x / (guess ** 2.) + 2. * guess) / 3.
    let goodEnough guess  =
        // abs (((improve guess x) - guess) / guess) < 0.0000001 
        let nextGuess = improve guess
        let guessDiff = (nextGuess - guess) / guess

        guessDiff
        |> abs 
        |> (>) 0.00000001
    
    let rec sqrtIter  guess  =
        if goodEnough guess 
        then guess
        else sqrtIter (improve guess)

    sqrtIter 1.0

cubeRoot 27
cubeRoot 42
cubeRoot 64

let rec factorial n = 
    if n = 1 
    then 1 
    else n * factorial (n-1)

factorial 1
factorial 2
factorial 3
factorial 4

let factorial n =
    let rec fatcIter product counter =
        if counter > n
        then product 
        else fatcIter (product * counter) (counter+1)
    
    fatcIter 1 1

factorial 1
factorial 2
factorial 3
factorial 4

let factorial n =
    let mutable product = 1
    for i in 1..n do
        product <- product * i
    product
    
factorial 1
factorial 2
factorial 3
factorial 4

let rec A x y =
    match (x, y) with
    | (_, y) when y = 0 -> 0
    | (x, _) when x = 0 -> y*2
    | (_, y) when y = 1 -> 2
    | _ -> A (x-1) (A x (y-1)) 


A 1 10
A 2 4
A 3 3 

let rec fib n =
    match n with
    | 0 -> 0
    | 1 -> 1
    | _ -> fib (n-1) + fib (n-2)

fib 0
fib 1
fib 2
fib 3
fib 8

let fib n =
    let rec fibIter a b count =
        if count = 0
        then b
        else fibIter (a+b) a (count-1)

    fibIter 1 0 n

fib 0
fib 1
fib 2
fib 3
fib 8

let countChange amount =

    let firstDenomination kindsOfCoins =
        match kindsOfCoins with
        | 1 -> 1
        | 2 -> 5
        | 3 -> 10
        | 4 -> 25
        | 5 -> 50

    let rec cc amount kindsOfCoins =
        match amount with
        | 0 -> 1
        | amount when amount < 0 || kindsOfCoins = 0 -> 0
        | _ -> cc amount (kindsOfCoins-1) + cc (amount - (firstDenomination kindsOfCoins)) kindsOfCoins

    cc amount 5

countChange 100
countChange 3
countChange 5
countChange 10
