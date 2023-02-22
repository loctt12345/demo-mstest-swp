using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_mstest_swp.Models
{
    class Student : Person
    {
        public string Course { get; set; }
        public Student (string name, int age, string address, string course)
            : base(name, age, address)
        {
            Course = course;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Course: {Course}");
        }
    }
}
