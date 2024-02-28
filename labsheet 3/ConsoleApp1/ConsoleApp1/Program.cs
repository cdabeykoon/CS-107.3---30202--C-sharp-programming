using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
            public class Course
        {
            private string courseName;
            private string instructorName;
            private double grade;

            // Constructor
            public Course(string courseName, string instructorName, double grade)
            {
                CourseName = courseName;
                SetInstructorName(instructorName);
                Grade = grade;
            }

            // Public read-only property for CourseName
            public string CourseName { get; }

            // Public read-only property for Grade with validation
            public double Grade
            {
                get { return grade; }
                private set
                {
                    if (value < 0 || value > 100)
                    {
                        throw new ArgumentOutOfRangeException(nameof(Grade), "Grade must be between 0 and 100.");
                    }
                    grade = value;
                }
            }

            // Public method to set the instructor's name with validation
            public void SetInstructorName(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Instructor name cannot be empty or whitespace.", nameof(name));
                }
                instructorName = name;
            }

            // Private method to calculate the letter grade based on the numeric grade
            private string CalculateLetterGrade()
            {
                if (Grade >= 90)
                {
                    return "A";
                }
                else if (Grade >= 80)
                {
                    return "B";
                }
                else if (Grade >= 70)
                {
                    return "C";
                }
                else if (Grade >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }

            // Public method to print course info including course name, instructor name, and letter grade
            public void PrintCourseInfo()
            {
                string letterGrade = CalculateLetterGrade();
                Console.WriteLine($"Course: {CourseName}");
                Console.WriteLine($"Instructor: {instructorName}");
                Console.WriteLine($"Grade: {letterGrade}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Example usage
                Course course = new Course("Mathematics", "Professor Smith", 87);
                course.PrintCourseInfo();
            }
        }
    
    
}
