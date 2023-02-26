
using System;
using demo_mstest_swp.Models;

namespace demo_mstest_swp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int rs = MathUtils.GetSumNFirstNum(1);
            Console.WriteLine(rs);
            
            Student myStudent = new Student("John", 20, "Computer Science", 8.8);
            Console.WriteLine(myStudent.ConvertGPAOutOfFourRoundToTens());
        }
    }
}
