#lang racket
; (+ 12 42)

; (+ 21 35 12 7)

; (+ (* 3
;       (+ (* 2 4)
;          (+ 3 5)))
;    (+ (- 10 7)
;       6))

; (define size 2)

; (define pi 3.14159)
; (define radius 10)
; (* pi (* radius radius))
; 314.159
; (define circumference (* 2 pi radius))


; (* (+ 2 (* 4 6))
;    (+ 3 5 7))

; (define (square x) (* x x))
; (square 21)
; (square (+ 2 5))


; (define (sum-of-squares x y)
;   (+ (square x) (square y)))

; (sum-of-squares 3 4)

; (define (f a)
;   (sum-of-squares (+ a 1) (* a 2)))
; (f 5)

; (define (abs x)
;   (cond ((> x 0) x)
;         ((= x 0) 0)
;         ((< x 0) (- x))))

; (abs 12)
; (abs 0)
; (abs -42)

; (define (abs x)
;   (cond ((< x 0) (- x))
;         (else x)))

; (abs 12)
; (abs 0)
; (abs -42)

; (define (abs x)
;   (if (< x 0)
;       (- x)
;       x))

; (abs 12)
; (abs 0)
; (abs -42)

; (define (testCond x)
;   (and (> x 5) (< x 10)))

; (testCond 42)
; (testCond 7)
; (testCond -10)

; (define (>= x y)
;     (or (> x y) (= x y)))

; (>= 6 10)


(/ (+ 5 4 (- 2 (- 3 (+ 6 (/ 4 5)))))
   (* 3 (- 6 2) (- 2 7)))

(define (square x) (* x x))

(define (sum-of-squares x y)
  (+ (square x) (square y)))

; сумма двух больших
; y > x
;
;

; (define (golloolo x y z)
;   (cond ((and
;           (or (>= x y) (>= x z))
;           (>= y z))
;          (sum-of-squares x y))

;         ((and (> x y) (> z y)) (sum-of-squares x z))

;         (else (sum-of-squares y z)) ))

; (define (golloolo x y z)
;   (cond ((and (>= x z) (>= y z)) (sum-of-squares x y))
;         ((and (>= x y) (>= z y)) (sum-of-squares x z))
;         (else (sum-of-squares y z))))

; (golloolo 1 1 1)
; (golloolo 2 1 2)
; (golloolo 1 2 2)
; (golloolo 1 2 1)
; (golloolo 2 2 1)

; " "

; (golloolo 3 2 1)
; (golloolo 1 2 2)
; (golloolo 3 1 3)
; (golloolo 5 1 3)
; (golloolo 3 3 3)
; (golloolo 1 5 3)
; (golloolo 3 5 1)

(define (improve guess x)
  (average guess (/ x guess)))

(define (average x y)
  (/ (+ x y) 2))

; (guess_n+1 - guess_n) / guess_n

; (1.4142 - 1.4167) / 1.4167

; (define (sqrt1 x)

;   (define (good-enough1? guess x)
;     (< (abs (- (square guess) x)) 0.0001))

;   (define (sqrt-iter1 guess x)
;     (if (good-enough1? guess x)
;         guess
;         (sqrt-iter1 (improve guess x)
;                     x)))

;   (sqrt-iter1 1.0 x))

; (define (sqrt2 x)

;   (define (sqrt-iter2 guess x)
;     (if (good-enough2? guess x)
;         guess
;         (sqrt-iter2 (improve guess x)
;                     x)))

;   (define (good-enough2? guess x)
;     (< (abs (/
;              (- (improve guess x) guess)
;              guess))
;        0.000000000001))
;   (sqrt-iter2 1.0 x))

; (sqrt1 10)
; (sqrt1 9)
; (sqrt1 4.2e20)

; (sqrt2 10)
; (sqrt2 9)
; (sqrt2 4.2e20)


; (define (cube-root x)

;   (define (good-enough? guess)
;     (< (abs (/
;              (- (cube-improve guess) guess)
;              guess))
;        0.000000000001))

;   (define (cube-improve guess)
;     (/
;      (+ (/ x (square guess)) (* 2 guess))
;      3))


;   (define (cube-root-iter guess)
;     (if (good-enough? guess)
;         guess
;         (cube-root-iter (cube-improve guess))))

;   (cube-root-iter 1.0))

; (cube-root 27)
; (cube-root 42)
; (cube-root 64)

; (define (factorial n)
;   (if (= n 1)
;       1
;       (* n (factorial (- n 1)))))

; (define (factorial n)
;   (define (fact-iter product counter)
;     (if (> counter n)
;         product
;         (fact-iter (* product counter) (+ counter 1))))

;   (fact-iter 1 1))

; (factorial 1)
; (factorial 2)
; (factorial 3)
; (factorial 6)

; (define (inc a)
;   (+ a 1))

; (define (dec a)
;   (- a 1))

; (define (+ a b)
;   (if (= a 0)
;       b
;       (inc (+ (dec a) b))))

; (define (+ a b)
;   (if (= a 0)
;       b
;       (+ (dec a) (inc b))))

; (+ 4 5)


; (+ 4 5)
; (inc (+ (dec a) b)))
; (inc (+ 4 5)))
; (inc (+ 3 5)))
; (inc (+ 2 5)))
; (inc (+ 1 5)))
; (inc (+ 0 5)))
; 5
;

; (define (A x y)
;   (cond ((= y 0) 0)
;         ((= x 0) (* 2 y))
;         ((= y 1) 2)
;         (else (A (- x 1)
;                  (A x (- y 1))))))

; (A 1 10)
; (A 2 4) ; = 65536
; (A 3 3) ; = 65536

; (define (fib n)
;   (cond ((= n 0) 0)
;         ((= n 1) 1)
;         (else (+ (fib (- n 1))
;                  (fib (- n 2))))))

; (define (fib n)
;   (define (fib-iter a b count)
;     (if (= count 0)
;         b
;         (fib-iter (+ a b) a (- count 1))))

;   (fib-iter 1 0 n))

; (fib 0)
; (fib 1)
; (fib 2)
; (fib 3)
; (fib 8)

(define (count-change amount)
  (define (cc amount kinds-of-coins)
    (cond ((= amount 0) 1)
          ((or (< amount 0) (= kinds-of-coins 0)) 0)
          (else (+ (cc amount
                       (- kinds-of-coins 1))
                   (cc (- amount
                          (first-denomination kinds-of-coins))
                       kinds-of-coins)))))

  (define (first-denomination kinds-of-coins)
    (cond ((= kinds-of-coins 1) 1)
          ((= kinds-of-coins 2) 5)
          ((= kinds-of-coins 3) 10)
          ((= kinds-of-coins 4) 25)
          ((= kinds-of-coins 5) 50)
          ((= kinds-of-coins 6) 3)))
  (cc amount 6))

(count-change 100)
(count-change 3)
(count-change 5)
(count-change 10)
