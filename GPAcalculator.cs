using System;
using System.Collections.Generic;

class Course
{
    public string Name { get; set; }
    public int Grade { get; set; } 
}

class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }
    public decimal GPA { get; private set; }
    
    public void CalculateGPA()
    {
        decimal totalGrades = 0;
        int totalCourses = 0;

        foreach (var course in Courses)
        {
            totalGrades += (decimal)course.Grade;
            totalCourses++;
        }

        GPA = totalCourses == 0 ? 0 : (decimal)totalGrades / totalCourses;
    }

    public void PrintGPA()
    {
        CalculateGPA(); 
        Console.WriteLine($"Student {Name} has the following GPA: {GPA:F2}");
    }
}

class Program
{
    static void Main()
    {
        var student = new Student
        {
            Name = "John Doe",
            Courses = new List<Course>
            {
                new Course { Name = "Math", Grade = 3 },
                new Course { Name = "English", Grade = 4 },
                new Course { Name = "History", Grade = 2 },
                new Course { Name = "Science", Grade = 3 }
            }
        };

        var student2 = new Student
        {
            Name = "Pinja Kokkola",
            Courses = new List<Course>
            {
                new Course { Name = "Math", Grade = 4 },
                new Course { Name = "English", Grade = 4 },
                new Course { Name = "History", Grade = 4 },
                new Course { Name = "History II", Grade = 4 },
                new Course { Name = "Cloud Computing", Grade = 1 },
                new Course { Name = "Science", Grade = 4 }
            }
        };
        
        var student3 = new Student
        {
            Name = "Pirkko Mattila",
            Courses = new List<Course>
            {
            }
        };

        student.PrintGPA();
        student2.PrintGPA();
        student3.PrintGPA();
    }

}