module Doubler
    def double
        self + self
    end
end

class Pt
    attr_accessor :x, :y
    include Doubler
    def + other # when you call Pt.double, it will call folllowing method
        ans = Pt.New
        ans.x = self.x + other.x
        ans.y = self.y + other.y
        ans
    end
end

class String
    include Doubler
end
