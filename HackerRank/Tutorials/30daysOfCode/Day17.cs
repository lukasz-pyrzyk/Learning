using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30daysOfCode
{
    class Day17
    {
        class Calculator
        {
            public int power(int n, int p)
            {
                if (n < 0 || p < 0)
                {
                    throw new Exception("n and p should be non-negative");
                }

                return (int)Math.Pow(n, p);
            }
        }
    }
}
