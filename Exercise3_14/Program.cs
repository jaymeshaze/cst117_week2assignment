using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14. Write a C# program to convert meters to feet or inches. There are 39.37 inches in one
//meter and 12 inches in a foot.If the length is less than 1 foot, just report the number of
//inches. Show two digits after the decimal point. Thus 3.4 meters converts to 11.15 feet,
//and .2 meter converts to 7.87 inches.

namespace Exercise3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length in meters: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine(convertLength(length));
        }
        static string convertLength(double x)
        {
            double meters = x;
            double inches = calcInches(meters);
            double feet = calcFeet(inches);

            if(inches > 12)
            {
                return String.Format("{0} meters converts to {1:0.00} feet.", x, feet);
            }
            else
            {
                return String.Format("{0} meters converts to {1:0.00} inches.", x, inches);
            }
        }
        static double calcInches(double x)
        {
            double meters = x;
            double inches = x * 39.37;
            return inches;
        }
        static double calcFeet(double x)
        {
            double inches = x;
            double feet = inches / 12;
            return feet;
        }
    }
}
