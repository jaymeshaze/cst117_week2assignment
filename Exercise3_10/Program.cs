using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10. Write a C# program that checks a grade point average the user inputs, and outputs
//Congratulations, You made the honor roll if the average is 3.5 and above,
//but outputs Sorry, You are on probation if the average is below 2.0.

namespace Exercise3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            Console.WriteLine("Enter your GPA: ");
            double userGpa = double.Parse(Console.ReadLine());
            Console.WriteLine(checkGPA(userGpa));
        }
        static string checkGPA(double x)
        {
            if(x >= 3.5)
            {
                return "Congratulations, You made honor roll";
            }
            else if(x < 3.5 && x >= 2)
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
