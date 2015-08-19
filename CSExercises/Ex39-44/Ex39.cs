using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        static void main()
        {
            Console.WriteLine("Enter a number:\t");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
        public static long Factorial(long n)
        {
            long i = 0;
            long num = 1;
            while (n != 0)
            {
                
                num = num*(n - i);
                i++;
            }
            return num;
        }
    }
}
