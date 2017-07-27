#lang racket

(provide (all-defined-out))

(define (max-of-list xs)
  (cond [(null? xs) (error "max-of-list given empty list")]
        [(null? (cdr xs)) (car xs)]
        [ #t (let ([tlans (max-of-list (cdr xs))])
               (if (> tlans (car xs))
                      tlans
                      (car xs)))]))

;; LET - the expressions are evaluated in the environment from before the let-expression
;; this is not how ML let-expresson work
(define (silly-double x)
  (let ([x (+ x 3)]
        [y (+ x 2)])
    (+ x y -5)))

;; LET* - the expression are evaluated in the environment produced from the previous bindings
(define (silly-double2 x)
  (let* ([x (+ x 3)] ;; shadow x from previos line
         [y (+ x 2)]) ;; x referes to the line above
    (+ x y -8)))

;; LETREC - the expressions are evaluated in the environment that includes all bindings. Like 'AND' in ML
;; needed for mutual recursion
;; but expresson are still evaluated in order. Accesing and uninitialized binding would produce an error
;; USE ONLY FOR MUTUAL RECURSION! No need in another cases
 (define (silly-triple x)
   (letrec ([y (+ x 2)]
            [f (lambda(z) (+ z y w x ))]
            [w (+ x 7 )])
     (f -9)))

;; local define - in certaions positions, like the beginning of function bodies, you can put defines
;; Local defines is preferred Racket style
(define (silly-mod2 x)
  (define (even? x) (if (zero? x) #t (odd? (- x 1))))
  (define (odd? x) (if (zero? x) #f (even? (- x 1))))
  (if (even? x) 0 1))