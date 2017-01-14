using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12. Write a C# program that will find the first word, in alphabetical order, from a list of
//words entered by the user in an input dialog.

namespace Exercise6_12
{
    class Program
    {
        static void Main(string[] args)
        {
            String x = "y";

            Console.WriteLine("Enter a word: ");
            String firstWord = Console.ReadLine();

            Console.WriteLine("Enter another word? 'y' or 'n'");
            x = Console.ReadLine();

            while (x == "y")
            {
                Console.WriteLine("Enter a word: ");
                String nextWord = Console.ReadLine();

                if (nextWord.CompareTo(firstWord) < 0)
                {
                    firstWord = nextWord;
                }

                Console.WriteLine("Enter another word? 'y' or 'n'");
                x = Console.ReadLine();
            }
            Console.WriteLine("The first word, in alphabetical order, is {0}.", firstWord);
        }
    }

}
