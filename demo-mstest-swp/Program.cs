using System;
namespace demo_mstest_swp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test
            bool rs = MathUtils.IsPalindrome(19391);
            Console.WriteLine(rs);
        }
    }
}
