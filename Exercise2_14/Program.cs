using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//14. Write a static method with one integer parameter and let it return the remainder of that
//integer when divided by 7. For example, FindRemainder(19) should return 5.In
//the Main method, initialize two variables, x and y, with values 73 and 16.Call the
//FindRemainder method three times, with the arguments x, y, and x + y, each time
//displaying the result returned by FindRemainder.

namespace Exercise2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 73;
            int y = 16;
            Console.WriteLine(FindRemainder(x));
            Console.WriteLine(FindRemainder(y));
            Console.WriteLine(FindRemainder(x + y));
        }
        static int FindRemainder(int x)
        {
            return x % 7;
        }
    }
}
