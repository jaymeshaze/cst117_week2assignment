﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10. Do Exercise 10 of Chapter 3 (Write a C# program that checks a grade point average the
//user inputs, and outputs “Congratulations, You made the honor roll” if the
//average is 3.5 and above, but outputs “Sorry, You are on probation” if the average
//is below 2.0.) with the added condition that the grade point average is between 0.0
//and 4.0.

namespace Exercise4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter GPA (between 0.0 and 4.0): ");
            double gpa = double.Parse(Console.ReadLine());
            while(gpa > 4.0 || gpa < 0.0)
            {
                Console.WriteLine("Invalid GPA. Please enter a GPA between 0.0 and 4.0: ");
                gpa = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(checkGPA(gpa));
        }
        static string checkGPA(double x)
        {
            if (x >= 3.5)
            {
                return "Congratulations, You made honor roll";
            }
            else if (x < 3.5 && x >= 2)
            {
                return ("Your GPA is " + x);
            }
            else
            {
                return "Sorry, You are on probation";
            }
        }
    }
}
