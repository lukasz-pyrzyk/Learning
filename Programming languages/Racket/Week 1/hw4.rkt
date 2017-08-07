
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

; AD 4
(define (stream-for-n-steps s n)
  (if (equal? n 0)
      null
      (let ([nextvalue (s)])
        (cons (car nextvalue) (stream-for-n-steps (cdr nextvalue) (- n 1))))))

; AD 5
(define funny-number-stream
  (letrec ([f (lambda (x) 
                (cons (if (equal? (remainder x 5) 0) (- 0 x) x) (lambda () (f (+ x 1)))))])
    (lambda () (f 1))))

; AD 6
(define dan-then-dog
  (lambda () (cons "dan.jpg" (lambda () (cons "dog.jpg" dan-then-dog)))))

; AD 7
(define (stream-add-zero s)
  (let ([nextValue (s)]) 
    (lambda () (cons (cons 0 (car nextValue))
                     (stream-add-zero (cdr nextValue))))))

; AD 8
(define (cycle-lists xs ys)
  (letrec ([f (lambda (n)
                (cons
                 (cons (list-nth-mod xs n) (list-nth-mod ys n))
                 (lambda () (f (+ n 1)))))])
    (lambda () (f 0))))

; AD 9
(define (vector-assoc v vec)
  (letrec ([f (lambda (n)
                (if (>= n (vector-length vec))
                    #f
                    (let ([n-th (vector-ref vec n)])
                      (if (and (pair? n-th) (equal? (car n-th) v))
                          n-th
                          (f (+ n 1))))))])
    (f 0)))

; AD 10
(define (cached-assoc xs n)
  (letrec ([memo (make-vector n #f)]
           [pos 0])
    (lambda (v) (or (vector-assoc v memo)
          (let ([new-ans (assoc v xs)])
            (and new-ans
                 (begin
                   (vector-set! memo pos new-ans)
                   (set! pos (remainder (+ pos 1) n))
                     new-ans)))))))


; AD 11
(define-syntax while-less
  (syntax-rules (do)
    [(while-less e1 do e2)
     (letrec ([a e1]
              [f (lambda ()
                   (if (>= e2 a)
                       #t
                       (f)))])
       (f))]))