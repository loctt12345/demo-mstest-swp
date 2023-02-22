// See https://aka.ms/new-console-template for more information

// Test Case Student
using demo_mstest_swp.Models;

Person p = new Person("Anh", "12/1/2020", "123");
p.Show();

IPerson ip = new Person("Van", "15/5/1993", "354");
ip.Show();

ip = new Student("Thanh", "8/2/1324", "12", "java");
ip.Show();

Student stu = (Student)ip;
stu.Show();
