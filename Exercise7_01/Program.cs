﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Given the array
//static int[] nums = { 45, 23, 67, 12, 11, 88, 3, 77 };
//what value does split(0,7) return, and how does the nums array change given the following
//C# code?
//static void Interchange(int a, int b)
//{
//    int temp = nums[a];
//    nums[a] = nums[b];
//    nums[b] = temp;
//}
//static int Split(int first, int last)
//{
//    int x, splitPoint;
//    x = nums[first];
//    splitPoint = first;
//    for (int i = first; i <= last; i++)
//        if (nums[i] < x)
//        {
//            splitPoint++;
//            Interchange(splitPoint, i);
//        }
//    Interchange(first, splitPoint);
//    return splitPoint;
//}


//ANSWER:
    //returns a value of 4, which is where the splitpoint value ends up in the array.
    //the nums array changes by putting all the numbers less than 45 in the array on the left side of the 45 in the array.

namespace Exercise7_01
{
    class Program
    {

        static int[] nums = { 45, 23, 67, 12, 11, 88, 3, 77 };

        static void Main(string[] args)
        {
            Console.WriteLine(Split(0, 7));
        }

        static void Interchange(int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
        static int Split(int first, int last)
        {
            int x, splitPoint;
            x = nums[first];
            splitPoint = first;
            for (int i = first; i <= last; i++)
                if (nums[i] < x)
                {
                    splitPoint++;
                    Interchange(splitPoint, i);
                }
            Interchange(first, splitPoint);
            return splitPoint;
        }

    }
}
