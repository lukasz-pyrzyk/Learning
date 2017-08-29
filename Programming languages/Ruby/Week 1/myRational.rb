class MyRational
    def initialize(num, den = 1)
        if den == 0
            raise "MyRational received an inapproprate argument"
        elsif den < 0
            @num = -num
            @den = -den
        else
            @num = num
            @den = den
        end
        reduce() # call private method
    end

    def to_s # ToString()
        ans = @num.to_s
        if @den != 1
            ans += "/"
            ans += @den.to_s
        end
        ans
    end

    def to_s2
        dens = ""
        dens = "/" + @den.to_s if @den != 1 #funny if syntax
        @num.to_s2 + dens
    end

    def to_s3
        "#{num}#{if @den==1 then "" else "/" + @den.to_s end}"
    end

    def add! r #mutate self in-place
        a = r.num
        b = r.den
        c = @num
        d = @den
        @num = (a * d) + (b * c)
        @den = b * d
        reduce()
        self

    def + r
        ans = MyRational.new(@num, @den)
        ans.add! r
        ans
    end
end