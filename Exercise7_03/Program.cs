using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3. Find the array that results from the execution of g(5,34), where the code for the method
//g is
//public static int[][] g(int n, int value)
//{
//    int[][] x = new int[n][];
//    for (int i = 0; i < x.Length; i++)
//    {
//        x[i] = new int[i + 1];
//        for (int j = 0; j < x[i].Length; j++)
//            x[i][j] = value;
//    }
//    return x;
//}

//ANSWER:
//    Prints to console window

namespace Exercise7_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = g(5, 34);

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                    Console.Write("[" + myArray[i][j] + "]");
            }
        }

        public static int[][] g(int n, int value)
        {
            int[][] x = new int[n][];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = new int[i + 1];
                for (int j = 0; j < x[i].Length; j++)
                    x[i][j] = value;
            }
            return x;
        }

    }
}
