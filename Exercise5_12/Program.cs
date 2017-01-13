using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12. Modify Example 3.7, Max.cs, to use an object. Keep the current maximum as an instance
//variable.Change the methods from class to instance methods.Create an instance in
//Main and use its methods to find the maximum.

namespace Exercise5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Max myMax = new Max();

            double price = GetDouble("Enter the first price, -1 to quit: ");
            while (price >= 0)
            {
                myMax.UpdateMax(price);
                price = GetDouble("Enter the next price, -1 to quit: ");
            }
            Console.WriteLine("The maximum is {0}", myMax.getMax());
        }
    
        // returns a double entered by the user
        public static double GetDouble(String prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }
    }
    public class Max
    {
        /* Input: The new price and the current maximum price
        * Output: The updated maximum
        */
        double max = 0;

        public Max() { }


        public void UpdateMax(double newPrice)
        {
            if (newPrice > max) // Note 1
                max = newPrice;
        }

        public double getMax()
        {
            return max;
        }
        public void resetMax()
        {
            max = 0;
        }
    }
}
