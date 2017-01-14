using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. Find the array that results from the execution of f(3,4,21) where the code for the
//method f is
//public static int[,] f(int n, int m, int value)
//{
//    int[,] x = new int[n][m];
//    for (int i = 0; i < x.GetLength(0); i++)
//        for (int j = 0; j < x.GetLength(1); j++)
//            x[i, j] = value;
//    return x;
//}


//ANSWER:
    //Prints to console window
    //creates an array that looks like this:
    //    [21][21][21]
    //    [21][21][21]
    //    [21][21][21]
    //    [21][21][21]

namespace Exercise7_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = f(3, 4, 21);

            for (int i = 0; i < myArray.GetLength(0); i++)
                for (int j = 0; j < myArray.GetLength(1); j++)
                    Console.WriteLine("[" + myArray[i, j] + "]");

        }

        public static int[,] f(int n, int m, int value)
        {
            int[,] x = new int[n,m];
            for (int i = 0; i < x.GetLength(0); i++)
                for (int j = 0; j < x.GetLength(1); j++)
                    x[i, j] = value;
            return x;
        }

    }
}
