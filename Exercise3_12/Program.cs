using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12. Write a C# program to make change. Enter the cost of an item that is less than one dollar.
//Output the coins given as change, using quarters, dimes, nickels, and pennies.Use
//the fewest coins possible. For example, if the item cost 17 cents, the change would be
//three quarters, one nickel, and three pennies.

namespace Exercise3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cost of the item (less than 1 dollar): ");
            int cost = int.Parse(Console.ReadLine());
            int change = 100 - cost;
            Console.WriteLine(processChange(change));
        }
        static string processChange(int x)
        {
            int total = x;
            int quarter = 0;
            int dime = 0;
            int nickel = 0;
            int penny = 0;

            while(total > 0){
                if(total >= 25)
                {
                    quarter++;
                    total = total - 25;
                }else if(total >= 10)
                {
                    dime++;
                    total = total - 10;
                }else if(total >= 5)
                {
                    nickel++;
                    total = total - 5;
                }else if(total >= 1)
                {
                    penny++;
                    total--;
                }
            }
            return ("The change is " + quarter + " quarters, " + dime + " dimes, " + nickel + " nickels and " + penny + " pennies.");
        }
    }
}
