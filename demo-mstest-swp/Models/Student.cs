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
        public Student() { }

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

        public string CheckGPA(double gpa)
        {
            if(gpa <= 0 || gpa >= 10) {
                throw new Exception("Invalid gpa. GPA must be between 0 .. 10!");
            } 
            if(gpa < 6) {
                return "GPA: " + gpa + " is average student";
            }
            if(gpa > 6 && gpa < 8) {
                return "GPA: " + gpa + " is good student";
            }

            return "GPA: " + gpa + " is excellent student";
        }

        public int GetAge(int age) 
        { 
            if(age < 6 || age > 18) {
                throw new ArgumentException("Age of student between 6 .... 18");
            } 
            return age;
        }
    }
}
