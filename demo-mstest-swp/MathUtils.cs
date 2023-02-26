using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_mstest_swp
{
    public static class MathUtils
    {
        /*
        * Find Sum of first N natural n
        * Input: int n
        * Output: sum = 1 + 2 + ... + (n-1) + n 
        * Constraint: n <= 65535
        */
        public static int GetSumNFirstNum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        /*
        * Find which numbers appear once in array
        * Input: array of int
        * Output: array of n which appear once in the input array
        * Constraint:
         1 <= arr.length <= 3 * 10^4
            -3 * 10^4 <= arr[i] <= 3 * 10^4 */
        public static int[] GetElementOnceInArray(int[] arr)
        {
            List<int> arrResult = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) count++;
                }
                if (count == 1)
                {
                    arrResult.Add(arr[i]);

                }
            }
            return arrResult.ToArray();
        }


        /*Given an integer n, return true if n is a palindrome, and false otherwise. 
         * An integer is a palindrome when it reads the same forward and backward.
         * For example, 121 is a palindrome while 123 is not.
         * Input: int n
         * Output: True
         Constraint: -2^31 <= n <= 2^31 - 1
         */

        public static bool IsPalindrome(int n)
        {
            bool result = false;
            int remaineder, sum = 0;
            int temp = n;
            while (n > 0)
            {
                //Get the remainder by dividing the n with 10  
                remaineder = n % 10;
                //multiply the sum with 10 and then add the remainder
                sum = (sum * 10) + remaineder;
                //Get the quotient by dividing the n with 10 
                n = n / 10;
            }
            if(sum == temp)  result = true; 
            return result;
        }
    }
}
