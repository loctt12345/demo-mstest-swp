using demo_mstest_swp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class FibonacciTesting
    {
        [TestMethod]
        public void testFibonacciGivenRightArgumentRunsWell()
        {

            // 1 1 2 3 5 8
            FibonacciCalculator fibo = new FibonacciCalculator();
            Assert.AreEqual(1, fibo.Fibonacci_Recursion(1));
            Assert.AreEqual(5, fibo.Fibonacci_Recursion(5));
            Assert.AreEqual(8, fibo.Fibonacci_Recursion(6));



        }


        [TestMethod]
        public void testFibonacciUpgradeGivenRightArgumentRunsWell()
        {

            // 1 1 2 3 5 8
            FibonacciCalculator fibo = new FibonacciCalculator();
            Assert.AreEqual(1, fibo.Fibonacci_Upgrade(1));
            Assert.AreEqual(5, fibo.Fibonacci_Upgrade(5));
            Assert.AreEqual(8, fibo.Fibonacci_Upgrade(6));

        }

    }
}
