using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//18. Write a static method with one integer parameter, x, that returns the value of the polynomial
//4x2 + 3x - 5. Call this method twice from the Main method, each time reading
//in the value of x and displaying the result.

namespace Exercise2_18
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter value for x: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Answer is {0}", findPolynomial(x));
            }

        }
        static int findPolynomial(int y)
        {
           double x = Convert.ToDouble(y);
           double tempX = 4 * x;
           double a = Math.Pow(tempX, 2);
           double b = 3 * x;
           return Convert.ToInt16((a + b) - 5);
        }
    }
}
