#lang racket
(provide (all-defined-out))

(define-syntax my-if
  (syntax-rules (then else)
    [(my-if e1 then e2 else e3)
     (if e 1 e 2 e3)]))

(define-syntax comment-out
  (syntax-rules ()
    [(comment-out ignore instead) instead]))