using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10.Write a program that reads three integers from the keyboard and outputs their sum
//and product.

namespace Exercise2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int numThree = int.Parse(Console.ReadLine());
            int sum = numOne + numTwo + numThree;
            int product = numOne * numTwo * numThree;
            Console.WriteLine("The sum of these three numbers is {0}", sum);
            Console.WriteLine("The product of these three numbers is {0}", product);
        }
    }
}
