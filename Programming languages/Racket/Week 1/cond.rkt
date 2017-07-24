#lang racket

(provide (all-defined-out))

(define (sum3 xs)
  (cond [(null? xs) 0]
        [(number? (car xs)) (+ (car xs) (sum3 (cdr xs)))]
        [#t (+ (sum3 (car xs)) (sum3 (cdr xs)))]))

(define (sum4 xs)
  (cond [(null? xs) 0]
        [(number? car(xs)) (+ (car xs) (sum4 (cdr xs)))]
        [(list? (car(xs))) (+ sum4 (car xs)) (sum4 (cdr xs))]
        [#t (sum4 (cdr xs))]))