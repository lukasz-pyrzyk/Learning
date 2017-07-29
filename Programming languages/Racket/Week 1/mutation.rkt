#lang racket

(provide (all-defined-out))
(define b 3)
(define f (lambda (x) (* 1 (+ x b))))
(define c (+ b 4)) ;7
(set! b 5)
(define z (f 4)) ; 9
(define w c); 7

; how to be safe? Use local bindings!
(define v 3)
(define fun
  (let ([v v])
    (lambda (x) (* 1 (+ x v)))))