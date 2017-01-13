using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//12. Modify Example 4.3 to use the switch statement of Figure 4.13 instead of nested ifelse
//statements.

namespace Exercise4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = IO.GetInt("Enter a test score or -1 to quit: ");
            while (score >= 0)
            {
                score = score / 10;
                switch (score)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4: Console.WriteLine("Score {0} receives an F", score);
                        break;
                    case 5: Console.WriteLine("Score {0} receives a D", score);
                        break;
                    case 6:
                    case 7: Console.WriteLine("Score {0} receives a C", score);
                        break;
                    case 8: Console.WriteLine("Score {0} receives a B", score);
                        break;
                    case 9:
                    case 10: Console.WriteLine("Score {0} receives an A", score);
                        break;
                    default: Console.WriteLine("Score can't be greater than 100, try again");
                        break;
                }
                score = IO.GetInt("Enter a test score or -1 to quit: ");
            }
        }
    }
}
