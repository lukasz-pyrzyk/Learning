class A
    
    def m1
        34
    end
        
    def m2 (x, y)
        z  = 7
        if x > y
            false
        else
            x + y * z
        end
    end
end

a = A.new
puts a.m1
puts a.m2(3, 4)


class B
    def m1
        4
    end
    def m3 x
        x.abs * 2 + self.m1
    end
end
b = B.new
puts b.m1
puts b.m3 5