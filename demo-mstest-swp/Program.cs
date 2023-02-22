using System;
namespace demo_mstest_swp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test
            int rs = MathUtils.GetSumNFirstNum(10);
            Console.Write("Sum of 10 first natural number: " + rs);
        }
    }
}
