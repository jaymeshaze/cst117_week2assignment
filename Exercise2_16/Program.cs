using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16. Write a program to convert degrees Fahrenheit to degrees Celsius.Input an integer
//Fahrenheit temperature and convert to an integer Celsius temperature using the formula
//Celsius = 5(Fahrenheit - 32) / 9.Output the result.

namespace Exercise2_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit: ");
            int tempFar = int.Parse(Console.ReadLine());
            int tempCel = convertTemp(tempFar);
            Console.WriteLine("The temperature in Celsius is {0}", tempCel);
        }
        static int convertTemp(int x)
        {
            return (5 * (x - 32)) / 9;
        }
    }
}
