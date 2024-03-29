﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter exam marks: ");
            int marks = int.Parse(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Error: Marks should be between 0 and 100.");
            }
            else
            {
                string grade;
                if (marks >= 75 && marks <= 100)
                {
                    grade = "A";
                }
                else if (marks >= 60)
                {
                    grade = "B";
                }
                else if (marks >= 50)
                {
                    grade = "C";
                }
                else if (marks >= 40)
                {
                    grade = "D";
                }
                else
                {
                    grade = "Failed";
                }

                Console.WriteLine($"Student's Name: {name}");
                Console.WriteLine($"Grade: {grade}");
            }
        }
    }
}
