using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12. Write a program to enter the height and width of a rectangle from the keyboard and output
//the area of the rectangle.

namespace Exercise2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the rectangle: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle: ");
            int width = int.Parse(Console.ReadLine());
            int area = height * width;
            Console.WriteLine("The area of the rectangle is {0}", area);
        }
    }
}
