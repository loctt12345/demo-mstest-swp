using System;
using System.Collections.Generic;
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
        public List<string> EnrolledCourses { get; set; }

        public Student(string name, int age, string major, double gpa)
        {
            Name = name;
            Age = age;
            Major = major;
            GPA = gpa;
            EnrolledCourses = new List<string>();
        }

        public void AddCourse(string course)
        {
            EnrolledCourses.Add(course);
        }

        public void RemoveCourse(string course)
        {
            EnrolledCourses.Remove(course);
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nMajor: {Major}\nGPA: {GPA}\nEnrolled Courses: {string.Join(", ", EnrolledCourses)}";
        }
    }
}
