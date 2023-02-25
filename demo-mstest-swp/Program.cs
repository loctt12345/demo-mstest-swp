// See https://aka.ms/new-console-template for more information

using demo_mstest_swp.Models;

Student myStudent = new Student("John", 20, "Computer Science", 8.5);
myStudent.ToString();
myStudent.CheckGPA(8.5);
Console.WriteLine(myStudent.ToString());


Student student1 = new Student();
Console.WriteLine(student1.CheckGPA(4.5));
Console.WriteLine(student1.GetAge(8));