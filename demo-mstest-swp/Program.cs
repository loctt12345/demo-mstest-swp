// See https://aka.ms/new-console-template for more information

// Test Case Student
using demo_mstest_swp.Models;

Person p = new Person("Anh", 12, "123HCM");
p.Show();

IPerson ip = new Person("Van", 15, "354HN");
ip.Show();

ip = new Student("Thanh", 8, "12DDN", "java");
ip.Show();

Student stu = (Student)ip;
stu.Show();
