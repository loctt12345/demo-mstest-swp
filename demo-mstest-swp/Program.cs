// See https://aka.ms/new-console-template for more information

using demo_mstest_swp.Models;

Student myStudent = new Student("John", 20, "Computer Science", 8.8);
Console.WriteLine(myStudent.ConvertGPAOutOfFourRoundToTens());