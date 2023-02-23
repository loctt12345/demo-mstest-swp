using demo_mstest_swp.Models;

namespace UnitTesting
{
    [TestClass]
    public class StudentTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student myStudent = new Student("John", 20, "Computer Science", 8.5);
            Assert.AreEqual(myStudent.Name, "John");
            Assert.AreEqual(myStudent.Age, 20);
            Assert.AreEqual(myStudent.Major, "Computer Science");
            Assert.AreEqual(myStudent.GPA, 8.5);
            Assert.AreEqual(myStudent.EnrolledCourses.Count, 0);

            myStudent.AddCourse("Introduction to Programming");
            myStudent.AddCourse("Data Structures and Algorithms");

            Assert.AreEqual(myStudent.EnrolledCourses.Count, 2);
            Assert.IsTrue(myStudent.EnrolledCourses.Contains("Introduction to Programming"));
            Assert.IsTrue(myStudent.EnrolledCourses.Contains("Data Structures and Algorithms"));

            myStudent.RemoveCourse("Introduction to Programming");

            Assert.AreEqual(myStudent.EnrolledCourses.Count, 1);
            Assert.IsFalse(myStudent.EnrolledCourses.Contains("Introduction to Programming"));
            Assert.IsTrue(myStudent.EnrolledCourses.Contains("Data Structures and Algorithms"));

            string expectedString = "Name: John Doe\nAge: 20\nMajor: Computer Science\nGPA: 3.5\nEnrolled Courses: Data Structures and Algorithms";
            Assert.AreEqual(myStudent.ToString(), expectedString);
        }
    }
}