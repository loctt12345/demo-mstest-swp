using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_mstest_swp
{
    public class FibonacciCalculator
    {

        public long Fibonacci_Recursion(int i)
        {
            if (i < 3) return 1;
            return (Fibonacci_Recursion(i - 2) + Fibonacci_Recursion(i - 1));
        }

        public long Fibonacci_Upgrade(int x)
        {
               
            // 1 1
            // 1 2
            // 2 3
            if (x < 3) return 1;
            long result = -9999999;
            long before = 1;
            long after = 1;
            for (int i = 3;  i <= x; i ++)
            {
                result = before + after;
                before = after;
                after = result;

            }

            return result;


        }
    }
}
