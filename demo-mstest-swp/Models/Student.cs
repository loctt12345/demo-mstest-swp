using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_mstest_swp.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }

        public Student(string name, int age, string major, double gpa)
        {
            Name = name;
            Age = age;
            Major = major;
            GPA = gpa;
        }

        public Student() { }

        public string GetTitleWithGPA()
        {
            if (this.GPA < 0 || this.GPA > 10) 
            {
                throw new FormatException("Invalid GPA. GPA must be between 0 .. 10!");
            } 

            if (this.GPA <= 10 && this.GPA >= 9)
            {
                return "Excellent";
            }

            if (this.GPA < 9 && this.GPA >= 8)
            {
                return "Very Good";
            }

            if (this.GPA < 8 && this.GPA >= 7)
            {
                return "Good";
            }

            if (this.GPA < 7 && this.GPA >= 5)
            {
                return "Average";
            }

            if (this.GPA < 5 && this.GPA >= 4)
            {
                return "Weak";
            }

            return "Poor";
        }

        public double ConvertGPAOutOfFourRoundToTens()
        {
            if (this.GPA < 0 || this.GPA > 10)
            {
                throw new FormatException("Invalid GPA. GPA must be between 0 .. 10!");
            }
            return Math.Round((this.GPA * 4) / (double) 10, 2);
        }
    }
}
