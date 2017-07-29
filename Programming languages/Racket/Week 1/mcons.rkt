#lang racket
(provide (all-defined-out))

(define x (cons 14 null))

(define y x)
(set! x (cons 42 null)) ; set x, still y points to 14

;(set! (car x) 45) ; won't work, Racket does not support mutating fields

(define mpr (mcons 1 (mcons #t "hi"))) ; you can use car / cdr functions on mcons, use mcar and mcdr
(set-mcdr! mpr 47)
(set-mcdr! mpr (mcons #t  "hi"))

; in summary, we have few more commands:
; mcons
; mcar
; mcdr
; mpair?
; set-mcar!
; set-mcdr!