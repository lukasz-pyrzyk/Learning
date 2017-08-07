
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

(define (stream-for-n-steps s n)
  (if (equal? n 0)
      null
      (let ([nextvalue (s)])
        (cons (car nextvalue) (stream-for-n-steps (cdr nextvalue) (- n 1))))))

(define funny-number-stream
  (letrec ([f (lambda (x) 
                (cons (if (equal? (remainder x 5) 0) (- 0 x) x) (lambda () (f (+ x 1)))))])
    (lambda () (f 1))))

(define dan-then-dog
  (lambda () (cons "dan.jpg" (lambda () (cons "dog.jpg" dan-then-dog)))))

(define (stream-add-zero s)
  (let ([nextValue (s)]) 
    (lambda () (cons (cons 0 (car nextValue))
                     (stream-add-zero (cdr nextValue))))))