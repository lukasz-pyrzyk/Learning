
#lang racket

(provide (all-defined-out)) ;; so we can put tests in a second file

;; put your code below

; AD 1
(define (sequence low high stride)
  (if (> low high)
      null
      (cons low (sequence (+ low stride) high stride))))

; AD 2
(define (string-append-map xs suffix)
  (map (lambda (i) (string-append i suffix)) xs))

; AD 3
(define (list-nth-mod xs n)
  (cond [(negative? n) (error "list-nth-mod: negative number")]
        [(empty? n) (error "list-nth-mod: empty list")]
        [#t (car (list-tail xs (remainder n (length xs))))]))