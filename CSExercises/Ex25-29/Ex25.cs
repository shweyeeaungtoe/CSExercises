using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
          // 25(a)
            Console.WriteLine("25(a)");
            Console.WriteLine("Enter a number:\t");
            int number = Convert.ToInt32(Console.ReadLine());

            int j = 1;

            for(int i=1;i<=number;i++)
            {
                j = j * i;

            }
            Console.WriteLine("Factorial of "+number+"! is\t"+j);




        /////////////////////////////////////////////////////////////////////
        // 25(b)
            Console.WriteLine("\n--------------------------------------------------------------------------\n\n25(b)");
            Console.WriteLine("Enter a number:\t");
            int number1 = Convert.ToInt32(Console.ReadLine());

            int j1 = 1;

            for (int i1 = number1; i1 > 0; i1--)
            {
                j1 = j1 * i1;

            }
            Console.WriteLine("Factorial of " + number1 + "! is\t" + j1);
        }
    }
}
