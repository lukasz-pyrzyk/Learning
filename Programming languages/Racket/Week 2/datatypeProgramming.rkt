#lang racket
(provide (all-defined-out))

(define (funny-sum xs)
    (cond [(null? xs)]
          [(number? (car xs)) (+ car xs) (funny-sum (cdr xs))]
          [(string? (car xs)) (+ (string-length (car xs)) (funny-sum (cdr xs)))]
    )
)

(define (Const i) (list `Const i))
(define (Negate e) (list `Negate e))
(define (Add e1 e2) (list `Add e1 e2))
(define (Multiply e1 e2) (list `Multiply e1 e2))

; just helper function that test what 'kind of exp'
; Note: More robust could raise better errors for non-exp values
(define (Const? x) (eq? (car x) `Const))
(define (Negate? x) (eq? (car x) `Negate))
(define (Add? x) (eq? (car x) `Add))
(define (Multiply? x) (eq? (car x) `Multiply))

; just helper functions that get the piecies for 'one kind of exp'
;(define (Const-int e) (car (cdr e)))
;(define (Negate-e e) (car (cdr e)))
;(define (Add-e1 e) (car (cdr e)))
;(define (Add-e2 e) (car (cdr (cdr e))))
;(define (Multiply-e1 e) (car (cdr e)))
;(define (Multiply-e2 e) (car (cdr (cdr e))))

; they are build-int funtions for getting 2nd, 3rd list elements
(define (Const-int e) cadr)
(define (Negate-e e) cadr)
(define (Add-e1 e) cadr)
(define (Add-e2 e) caddr)
(define (Multiply-e1 e) cadr)
(define (Multiply-e2 e) caddr)

(define (eval-exp e)
  (cond [(Const? e) e]
        [(Negate? e) (Const (- (Const-int (eval-exp (Negate-e e)))))]
        [(Add? e) (let ([v1 (Const-int (eval-exp (Add-e1 e)))]
                        [v2 (Const-int (eval-exp (Add-e2 e)))])
                    (Const (+ v1 v2)))]
        [(Multiply? e) (let ([v1 (Const-int (eval-exp (Multiply-e1 e)))]
                        [v2 (Const-int (eval-exp (Multiply-e2 e)))])
                    (Const (* v1 v2)))]
        [#t (error "eval-exp expected an exp")]))
                        