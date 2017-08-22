class A
    Age = 35 # public constant

    def initialize f #ctor
        @foo = f # field
        @@a = 5 #static
    end

    def m1
        @foo = 0
    end

    def m2 x
        @foo += x
        @bar = 0
    end

    def foo
        @foo
    end

    def A.m (x) # static method
        0
    end
end