using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_mstest_swp
{
    public static class MathUtils
    {
        //Find Sum of first N natural number
        //Input: n
        //Output: sum = 1 + 2 + ... + (n-1) + n 
        public static int GetSumNFirstNum(int n)
        {
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
